﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour
{
    public Transform Player;
    private CapsuleCollider2D cc;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Do something
        Player.transform.position = new Vector3(0, 0, 0);
    }

    private void Update()
    {

    }
}
