using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    float moveSpeed = 5f;
    //float dirX, dirY;
    float xSpeed, ySpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //dirX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        //dirY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        xSpeed = Input.GetAxis("Horizontal") * moveSpeed;
        ySpeed = Input.GetAxis("Vertical") * moveSpeed;


        //transform.position = new Vector2(transform.position.x + dirX, transform.position.y + dirY);
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(xSpeed, ySpeed);

    }
}
