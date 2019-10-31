using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Callback : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(MyRoutine(()=>
        {
            Debug.Log("the routine has finished");
        }));
    }
    public IEnumerator MyRoutine(Action onComplete=null)
    {
        yield return new WaitForSeconds(5.0f);
        if (onComplete!=null)
        {
            onComplete();
        }
    }
}
