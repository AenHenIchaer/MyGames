using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Employee
{
    public int employeeID;
    public string first, last;
    public int salary;
    public static string company;

    public Employee()
    {
        Debug.Log("instance members Initialized");
    }
    static Employee()
    {
        company = "Game";
        Debug.Log("Initialized static members");
    }
}
public class Initialization : MonoBehaviour
{
    // Initializing static member with a static constructor
    void Start()
    {
        Employee e1 = new Employee();
        var e2 = new Employee();
        var e3 = new Employee();
        var e4 = new Employee();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
