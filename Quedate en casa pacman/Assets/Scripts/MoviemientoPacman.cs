using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviemientoPacman : MonoBehaviour
{
    public float maxSpedd = 5f;
    public float speed = 20f;
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
            position.x--;
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
            position.x++;
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
            position.y++;
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
            position.y--;
            this.transform.position = position;

            up = false;
            down = true;
            left = false;
            right = false;
            animator.SetBool("caminando", true);
        }


    }



}
