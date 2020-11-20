using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour_v2 : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private float movementSpeed = 10f;
    private float jumpSpeed = 10f;
    //private int health = 5;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Jump");
        //transform.position = transform.position + new Vector3(h * movementSpeed * Time.deltaTime, v * jumpSpeed * Time.deltaTime, 0);
        if (h < 0f)
        {
            rb.velocity = new Vector2(h * movementSpeed, rb.velocity.y);
            transform.localScale = new Vector3(-1f, 1f, 0);
        }
        else if (h > 0f)
        {
            rb.velocity = new Vector2(h * movementSpeed, rb.velocity.y);
            transform.localScale = new Vector3(1f, 1f, 0);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        if(Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
        }

        //if (Input.GetAxis("Horizontal") > 0.1)
        //{
        //    sr.flipX = false;
        //}
        //else if (Input.GetAxis("Horizontal") < 0.1)
        //{
        //    sr.flipX = true;
        //}
    }


}
