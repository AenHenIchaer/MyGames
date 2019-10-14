using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Bank
{
    // Start is called before the first frame update
    public string branchName;
    public string location;
    public string cashInVault;
    public void CheckBalance()
    {
        Debug.Log("ChekingBalance:" + branchName);
    }
    public void Withdrawl()
    {
        Debug.Log("Withdrawling money from:" + branchName);
    }
    public void Deposit()
    {
        Debug.Log("Depositing monye to" + branchName);
    }
}
