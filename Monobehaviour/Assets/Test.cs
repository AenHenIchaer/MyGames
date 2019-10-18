using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Item //reference type = heap
{
    public string name;
    public int itemID;
    
    public Item(string name, int itemID)
    {
        this.name = name;
        this.itemID = itemID;
    }
}
public class Item2 //value type - stack
{
    public string name;
    public int itemID;

    public Item2(string name, int itemID)
    {
        this.name = name;
        this.itemID = itemID;
    }
}


public class Test : MonoBehaviour
{
    ContextMenuItemAttribute sword;
    private void Start()
    {
       
    }
    void ChangeValue(Item2 structItem)// value type
    {

    }
    void ChangeValue(Item classItem)// reference type
    {

    }
}
