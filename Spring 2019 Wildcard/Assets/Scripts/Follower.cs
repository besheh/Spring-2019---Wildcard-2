using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    void Start()
    {
        float size = target.GetComponent<DetectorBehavior>().range;
        transform.localScale *= new Vector2(size / 5, size / 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position;
    }
}
