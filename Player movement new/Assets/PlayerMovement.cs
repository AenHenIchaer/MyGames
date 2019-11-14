using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody rb;
    private Vector3 moveInput;
    private Vector3 moveVelocity;

    private Camera mainCamera;
    private Animator anim;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        mainCamera = Camera.main;
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        float lh = Input.GetAxis("Horizontal");
        float lv = Input.GetAxis("Vertical");
        moveInput = new Vector3(lh, 0f, lv);
        Vector3 cameraForward = mainCamera.transform.forward;
        cameraForward.y = 0;
        Quaternion cameraRealtiveRotation = Quaternion.FromToRotation(Vector3.forward, cameraForward);
        Vector3 lookToward = cameraRealtiveRotation * moveInput;
        if (moveInput.sqrMagnitude>0)
        {
            Ray lookRay = new Ray(transform.position, lookToward);
            transform.LookAt(lookRay.GetPoint(1));
        }

        moveVelocity = transform.forward * moveSpeed*moveInput.sqrMagnitude;
        Animating();

    }
    private void FixedUpdate()
    {
        rb.velocity = moveVelocity;
    }
    void Animating()
    {
        anim.SetFloat("blendSpeed", rb.velocity.magnitude);
    }
}
