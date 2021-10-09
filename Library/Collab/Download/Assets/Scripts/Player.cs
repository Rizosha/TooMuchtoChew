using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float maxHeight;
    public float minHeight;





    public int health = 3;
   
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W)&& transform.position.y < maxHeight)
            rb.MovePosition(rb.position + Vector2.up);

        if (Input.GetKeyDown(KeyCode.S) && transform.position.y > minHeight)
            rb.MovePosition(rb.position + Vector2.down);



        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     float jumpVelocity = 1;
        //     rb.velocity = Vector2.up * jumpVelocity;
        // }
    }
}
