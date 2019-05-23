using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class knifeBehavior : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)//check collision, if its an npc, kill it and itself
    {
        Trigger trig = col.GetComponent<Trigger>();
        if (trig != null)
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
        return;
    }

    public void setUp(float moveSpeed)//point towards mouse, move
    {
        Vector3 point = Input.mousePosition;
        point = Camera.main.ScreenToWorldPoint(point);
        Vector2 dir = new Vector2(point.x - transform.position.x, point.y - transform.position.y);
        transform.up = dir;
        Rigidbody2D body = GetComponent<Rigidbody2D>();
        body.velocity = transform.up * moveSpeed;
    }
}
