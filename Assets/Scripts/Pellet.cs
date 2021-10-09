using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pellet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 100;
    public Rigidbody2D rb;
    
    void Start()
    { //the pellet travels forward multiplied by a speed factor
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
       Enemy enemy = hitInfo.GetComponent<Enemy>(); //check if it collides with enemy
       Destroy(gameObject); //pellet gets destroyed
        if (enemy != null) //if enemy is found
        {
            enemy.TakeDamage(damage);
        }
    }
    
}
