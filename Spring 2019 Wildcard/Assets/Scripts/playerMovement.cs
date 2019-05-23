using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float shotSpeed;
    //float dirX, dirY;
    public float xSpeed, ySpeed;
    public Animator m_Animator;
    public bool canThrow;
    public GameObject knifePrefab;

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

        //example flag usage, we could also move it to flagmanager and change values there
        FlagManager manager = FindObjectOfType<FlagManager>();
        if (manager != null)
        {
            if(manager.getFlag(0)) moveSpeed = 10f;
        }

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

        if (Input.GetMouseButtonDown(0) && canThrow) {
            knifeBehavior knife = Instantiate(knifePrefab, transform.position, transform.rotation).GetComponent<knifeBehavior>();
            knife.setUp(shotSpeed);
            canThrow = false;
        }


    }

    public void getCaught()
    {
        canThrow = true;
        transform.position = new Vector2(-10, 0);
    }
}
