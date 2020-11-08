using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class MoviemientoPacman : MonoBehaviour
{
    public float speed = 0.3f;
    private Rigidbody2D rb2d;
    private bool left;
    private bool right;
    private bool up;
    private bool down;
    float delta = 3f;
    private Animator animator;
    private Transform playerRotation;

    void Start()
    {
        playerRotation = GetComponent<Transform>();
        
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        up = false;
        down = false;
        left = false;
        right = false;
        animator.SetBool("caminando", false);


        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

           
            playerRotation.rotation = Quaternion.Euler(0f, 0f, 180f);
           
            Vector3 position = this.transform.position;
            position.x-=0.3f;
            this.transform.position = position;

            up = false;
            down = false;
            left = true;
            right = false;
            animator.SetBool("caminando", true);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerRotation.rotation = Quaternion.Euler(0f, 0f, 0f);
            
            Vector3 position = this.transform.position;
            position.x+=0.3f; 
            this.transform.position = position;

            up = false;
            down = false;
            left = false;
            right = true;
            animator.SetBool("caminando", true);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {


            playerRotation.rotation = Quaternion.Euler(0f, 0f, 90f);

            Vector3 position = this.transform.position;
            position.y+=0.3f;
            this.transform.position = position;

            up = true;
            down = false;
            left = false;
            right = false;
            animator.SetBool("caminando", true);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            playerRotation.rotation = Quaternion.Euler(0f, 0f, -90f);
            
            Vector3 position = this.transform.position;
            position.y-=0.3f;
            this.transform.position = position;

            up = false;
            down = true;
            left = false;
            right = false;
            animator.SetBool("caminando", true);
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "LimiteRight")
        {
            transform.position = new Vector3(-5.64f, transform.position.y, transform.position.z);
        }
        if (collision.gameObject.tag == "LimiteLeft")
        {
            transform.position = new Vector3(5.64f, transform.position.y, transform.position.z);
        }
    }

}
