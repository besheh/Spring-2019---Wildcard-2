using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public playerMovement target;
    public float range;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.position - target.transform.position).sqrMagnitude < range) target.getCaught();
    }
}
