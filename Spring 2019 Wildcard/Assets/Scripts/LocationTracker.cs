using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LocationTracker : MonoBehaviour
{
    /*
     1 - top center
     2 - top right
     3 - bot right
     4 - bot center
     5 - bot left
     6 - top left
     7 - center ( office )
    */
    public int location = 7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        location = SelectLocation();
    }

    int SelectLocation()
    {
        string mapButton = EventSystem.current.currentSelectedGameObject.name;
        Debug.Log(mapButton);
        int newLocation = 7;
        switch (mapButton)
        {
            case "topCenterLocation":
                newLocation = 1;
                break;
            case "topRightLocation":
                newLocation = 2;
                break;
            case "botRightLocation":
                newLocation = 3;
                break;
            case "botCenterLocation":
                newLocation = 4;
                break;
            case "botLeftLocation":
                newLocation = 5;
                break;
            case "topLeftLocation":
                newLocation = 6;
                break;
            case "centerLocation":
                newLocation = 7;
                break;
        }
        return newLocation;
    }
}
