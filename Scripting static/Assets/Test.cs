using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private Score score;
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Screkeeper").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Score.score += 10;
        }
    }
}
