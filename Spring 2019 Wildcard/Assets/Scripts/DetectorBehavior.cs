using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorBehavior : MonoBehaviour
{
    public playerMovement target;//literally should only ever be Player
    public float range;
    void Start()
    {
        
    }

    void Update()
    {
        if ((transform.position - target.transform.position).sqrMagnitude < range) target.getCaught(); //if player's in range, call getCaught
    }
}
