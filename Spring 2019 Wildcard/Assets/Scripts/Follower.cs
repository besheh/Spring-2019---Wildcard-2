using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position;
    }
}
