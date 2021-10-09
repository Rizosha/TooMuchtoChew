using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
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
        rb.MovePosition(rb.position + Vector2.left * speed * UnityEngine.Time.deltaTime);
       
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






