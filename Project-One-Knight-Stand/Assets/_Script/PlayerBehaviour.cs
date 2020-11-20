using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    //private Rigidbody2D rb;
    //private SpriteRenderer sr;
    private float movementSpeed = 10f;
    private float jumpSpeed = 15f;
    //private int health = 5;

    //void Start()
    //{
    //    rb = GetComponent<Rigidbody2D>();
    //    sr = GetComponent<SpriteRenderer>();
    //}

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Jump");
        transform.position = transform.position + new Vector3(h * movementSpeed * Time.deltaTime, v * jumpSpeed * Time.deltaTime, 0);
        if (h < 0)
            transform.localScale = new Vector3(-1f, 1f, 0);
        else if (h > 0)
            transform.localScale = new Vector3(1f, 1f, 0);
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
