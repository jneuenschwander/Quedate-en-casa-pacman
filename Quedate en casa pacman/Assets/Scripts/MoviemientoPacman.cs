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


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;

            up = false;
            down = false;
            left = true;
            right = false;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;

            up = false;
            down = false;
            left = false;
            right = true;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.y++;
            this.transform.position = position;

            up = true;
            down = false;
            left = false;
            right = false;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.y--;
            this.transform.position = position;

            up = false;
            down = true;
            left = false;
            right = false;
        }

    }



}
