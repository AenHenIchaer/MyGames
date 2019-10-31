using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Main3 : MonoBehaviour
{
    //create a delegate of type int that takes  numbers as a parameter and adds the sum
    public Func<int, int, int> onCalculateSum;
    private void Start()
    {
        onCalculateSum = (a, b) => a + b;
        var total= onCalculateSum(5, 5);
        Debug.Log(total);
    }
    int CalculateSum(int a, int b)
    {
        return a + b;
    }
}
