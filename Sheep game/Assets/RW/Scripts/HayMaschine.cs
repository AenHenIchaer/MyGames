using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HayMaschine : MonoBehaviour
{
    public float movementSpeed;
    public float horizontalEnding=22;
    public GameObject hayBalePrefab;
    public Transform haySpawnPoint;
    public float shootInterval;
    private float shootTimer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UpdateMovement();
        UpdateShooting();
    }

    private void UpdateShooting()
    {
        shootTimer -= Time.deltaTime;
        if (shootTimer <=0 && Input.GetKey(KeyCode.Space))
        {
            shootTimer = shootInterval;
            ShootHay();
        }
    }
    private void ShootHay()
    {
        Instantiate(hayBalePrefab, haySpawnPoint.position, Quaternion.identity);
        SoundManager.Instance.PlayShootClip();
    }
    private void UpdateMovement()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        if (horizontalInput < 0 && transform.position.x> -horizontalEnding)
        {
            transform.Translate(transform.right * -movementSpeed * Time.deltaTime);
        }
        else if (horizontalInput > 0 && transform.position.x<horizontalEnding)
        {
            transform.Translate(transform.right * movementSpeed * Time.deltaTime);
        }
    }
}


