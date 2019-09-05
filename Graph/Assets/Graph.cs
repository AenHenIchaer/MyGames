﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    public Transform pointPrefab;
    
    [Range(10,100)]public int resolution = 10;
    public GraphFunctionName function
    
    public int function;
    void Awake()
    {
        points = new Transform[resolution * resolution];
        Vector3 scale = Vector3.one * step;
        Vector3 position;
        position.y = 0f;
        position.z = 0f;
        for (int i = 0, x = 0, z = 0; i < points.Length; i++, x++)
        {
            if (x == resolution)
            {
                x = 0;
                z += 1;
            }
            Transform point = Instantiate(pointPrefab);
            position.x = (x + 0.5f) * step - 1f;
            position.z = (z + 0.5f) * step - 1f;
            point.localPosition = position;
            point.localScale = scale;
            point.SetParent(transform, false);
            points[i] = point;
        }



    }
     float SineFunction(float x,float z, float t)
    {
        return Mathf.Sin(Mathf.PI * (x + t));
    }
     float MultiSineFunction (float x, float z, float t)
    {
        float y = Mathf.Sin(Mathf.PI * (x + t));
        y+= Mathf.Sin(2f*Mathf.PI * (x +2f* t))/2f;
        y *= 2f / 3f;
        return y;
    }
static GraphFunction[] functions = SineFunction, MultiSineFunction;

    // Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time;
    GraphFunction f=functions[(int)function];
   

    for (int i = 0; i < points.Length; i++)
        {
            Transform point = points[i];
            Vector3 position = point.localPosition;

            position.y = f(position.x, position.z, t);
            point.localPosition = position;
        }
    }
}
