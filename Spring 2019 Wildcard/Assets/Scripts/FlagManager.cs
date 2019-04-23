using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagManager : MonoBehaviour
{

    public bool[] flags = new bool[2];
    // Update is called once per frame
    void Update()
    {
        
    }

    public void upFlag(int index)
    {
        if (index < 0) return;
        if (!flags[index]) flags[index] = true;
    }

    public bool getFlag(int index)
    {
        return flags[index];
    }
}
