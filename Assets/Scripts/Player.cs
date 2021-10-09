using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //players rigid body
    public Rigidbody2D rb; 

    //height restrictions 
    public float maxHeight;
    public float minHeight;




    //player health 
    public int health = 3;
   
    void Update()
    {
        //moves the player via vector 2 when a key is pushed, this has the restriction of min and max height applied
        if (Input.GetKeyDown(KeyCode.W)&& transform.position.y < maxHeight)
            rb.MovePosition(rb.position + Vector2.up);

        if (Input.GetKeyDown(KeyCode.S) && transform.position.y > minHeight)
            rb.MovePosition(rb.position + Vector2.down);




        // we tried to incorporate a jump mechanic. Didn't work out.
        

        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     float jumpVelocity = 1;
        //     rb.velocity = Vector2.up * jumpVelocity;
        // }
    }
}
