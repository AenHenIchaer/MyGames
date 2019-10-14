using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class FederalCreditUnion : Bank
{
    public int availableCastToLend;
    public void ApproveLending()
    {
        Debug.Log("You awarded a lawn");
    }
}
