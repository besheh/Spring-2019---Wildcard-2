using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    float moveSpeed = 5f;
    //float dirX, dirY;
    float xSpeed, ySpeed;
    public Animator m_Animator;
    

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

        if (m_Animator)
        {
            m_Animator.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal") + Input.GetAxis("Vertical") * moveSpeed));
        }

        if (Input.GetAxis("Horizontal") < 0)
            this.GetComponent<SpriteRenderer>().flipX = true;
        else if (Input.GetAxis("Horizontal") > 0)
            this.GetComponent<SpriteRenderer>().flipX = false;


        //transform.position = new Vector2(transform.position.x + dirX, transform.position.y + dirY);
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(xSpeed, ySpeed);


        if (FindObjectOfType<FlagManager>().getFlag(0)) moveSpeed = 10f;

        if(Input.GetKeyDown(KeyCode.Z))
        {
            if(!FindObjectOfType<DialogueManager>().talking){
                double minDistance = 5f;
                Trigger closest = null;
                Trigger[] allNPCS = GameObject.FindObjectsOfType<Trigger>();

                foreach (Trigger current in allNPCS)
                {
                    float distance = (current.transform.position - this.transform.position).sqrMagnitude;
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closest = current;
                    }
                }
                if(closest != null) closest.startTalking();
            }
            else
            {
                FindObjectOfType<DialogueManager>().displayNext();
            }
        }

    }
}
