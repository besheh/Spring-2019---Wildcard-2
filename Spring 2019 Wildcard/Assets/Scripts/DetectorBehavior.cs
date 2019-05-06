using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorBehavior : MonoBehaviour
{
    public bool looping;
    public int step;
    public NodeBehavior nodes;
    public int currentNode = 0;
    public Transform target;
    public float speed = 5f;

    void Start()
    {
        target = nodes.points[0];
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, target.position) <= .15f * speed)
        {
            if (currentNode >= nodes.points.Length - 1 || currentNode < 0)
            {
                if (looping)
                {
                    currentNode = 0;
                    target = nodes.points[currentNode];
                }
                else
                {
                    step = -step;
                    currentNode += step;
                    target = nodes.points[currentNode];
                }
            }
            else
            {
                currentNode += step;
                target = nodes.points[currentNode];
            }
        }


    }
}
