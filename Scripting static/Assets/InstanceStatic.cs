using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Player
{
    public string name;
    public int ID;

    public static int connectionCount;
    public Player()
    {
        connectionCount++;
    }
}
public class InstanceStatic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player p1 = new Player();
        Player p1 = new Player();
        Player.connectionCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
