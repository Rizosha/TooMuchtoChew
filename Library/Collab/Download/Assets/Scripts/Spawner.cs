using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{


    public GameObject prefab;
    public GameObject prefab2;
    public int respawnTime = 5;
    public int respawnMin = 2;



    void Start()
    {
        InvokeRepeating("Spawn", Random.Range(0f,5f), Random.Range(Random.Range(2,10), Random.Range(2, 10)));
    }



    void Spawn()
    {

  

        Instantiate(prefab, transform.position, Quaternion.identity);
    }

}