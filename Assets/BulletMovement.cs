using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField]
    private float bulletSpeed;
    static int score;

    private void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(0, bulletSpeed, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        score++;
        print("Score: " +score);
               
    }
}


