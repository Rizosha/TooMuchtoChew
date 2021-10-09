using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    // enemy prefab 
    public GameObject prefab; 
  
    public int respawnTime = 5;
    public int respawnMin = 2;



    void Start()
    {
        // uses invoke repeatnt to run the function Spawn within a random range of 2 and 8
        InvokeRepeating("Spawn", Random.Range(0f,5f), Random.Range(Random.Range(2,8), Random.Range(2, 8)));
    }



    void Spawn()
    {
        //finds the prefab and places it in the position of the ghost sprite
        Instantiate(prefab, transform.position, Quaternion.identity);
    }

}