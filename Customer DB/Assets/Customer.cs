using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Customer
{
    // Start is called before the first frame update
    public string firstName;
    public string lastName;
    public int age;
    public string gender;
    public string occupation;

    public Customer(string first, string last, int age, string gender, string occupation)
    {
        this.firstName = first;
        this.lastName = last;
        this.gender = gender;
        this.age = age;
        this.occupation = occupation;

    }
}
