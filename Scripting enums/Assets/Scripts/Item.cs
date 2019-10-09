using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    [System.Serializable]
    public class Item
    {
        public string name;
        public int ID;
        public Sprite icon;

        public enum Itemtype
        {
            None,
            Weapon,
            Consumable
        }
        public Itemtype itemType;
    public void Action()
    {
        switch (itemType)
        {
            
            case Itemtype.Weapon:
                Debug.Log("This is a "+itemType);
                break;
            case Itemtype.Consumable:
                Debug.Log("This is a consumbable");
                break;
           
               
        }
    }
    }

