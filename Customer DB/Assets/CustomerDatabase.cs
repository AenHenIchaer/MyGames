using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDatabase : MonoBehaviour
{
    
    public Customer johnathan;
    public Customer jessie, jannet;
    private void Start()
    {
        johnathan = new Customer("johnathan", "weinberger", 26, "M", "Engineer");
        jessie = new Customer("jessie", "", 55, "F", "Teacher");
        jannet = new Customer("jannet","", 25, "F", "");
    }
}
