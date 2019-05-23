using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour//just follows a detector to show range
{
    public GameObject target;
    void Start()
    {
        float size = target.GetComponent<DetectorBehavior>().range;
        transform.localScale *= new Vector2(size / 5, size / 5);
    }

    void Update()
    {
        transform.position = target.transform.position;
    }
}
