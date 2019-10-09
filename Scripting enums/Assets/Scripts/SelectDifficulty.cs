using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDifficulty : MonoBehaviour
{
   public enum LevelSelector
    {
        Easy,
        Normal,
        Hard
    }
    public LevelSelector currentLevel;
    
    // Start is called before the first frame update
    void Start()
    {
        switch (currentLevel)
        {
            case LevelSelector.Easy:
                break;
            case LevelSelector.Normal:
                break;
            case LevelSelector.Hard:
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
