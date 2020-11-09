using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCovid : MonoBehaviour
{
    private Rigidbody2D rb2d;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Vector3 position = this.transform.position;
            position.x -= 0.3f;
            this.transform.position = position;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Vector3 position = this.transform.position;
            position.x += 0.3f;
            this.transform.position = position;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {

            Vector3 position = this.transform.position;
            position.y += 0.3f;
            this.transform.position = position;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 position = this.transform.position;
            position.y -= 0.3f;
            this.transform.position = position;
        }
   }
}
