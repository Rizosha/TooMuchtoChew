using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    /// <summary>
    /// Here we have used many public scripts in order to access them accross the unity file. We have also created
    /// some private scripts as these are not needed to be accessed out side of this script
    /// This script creates how much damage and how fast the enemy is. This is then set towards the 
    /// -X axis so that it goes towards the player. We then added a collision box so that we can cause
    /// damage to the player which is a new function
    /// we also gave this enemy some health and said with the update function if it is to reach 
    /// 0 health then it will be destroyed and add to the score. To make the movement movement more fluid
    /// </summary>
    public int damage = 1; 
    public float speed; 
    public Rigidbody2D rb;
    public int playerh; 
    private GameObject playerc; 
    private GameObject health3;
    private GameObject health2; 
    private GameObject health1; 
    public int health = 100;
    public GameObject score;
    private int addScore = 100;
    private void Start() 
    {
        playerc = GameObject.Find("Scientist"); 
        score = GameObject.Find("Score"); 

    }

    private void Update()
    {
        rb.MovePosition(rb.position + Vector2.left * speed * UnityEngine.Time.fixedDeltaTime); 
       
    }

    void OnCollisionEnter2D(Collision2D col) { 
        if (col.gameObject.tag == "Player")
        {
            if (playerc.GetComponent<Player>().health > 0)
            {
               playerc.GetComponent<Player>().health = playerc.GetComponent<Player>().health - damage;
                Destroy(gameObject);
            }
        }
        
        if(col.gameObject.tag == "SpawnEnd") 
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage) 
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die() 
    {
        score.GetComponent<Score>().pscore += addScore;
        Destroy(gameObject);
    }

    


}






