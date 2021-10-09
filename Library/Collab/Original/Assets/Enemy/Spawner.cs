using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{


    public GameObject prefab;
    public int respawnTime = 5;
    public int respawnMin = 2;

    void Start()
    {
        InvokeRepeating("Spawn", 0f, Random.Range(respawnMin,respawnTime));
    }

    void Spawn()
    {

        Instantiate(prefab, transform.position, Quaternion.identity);
    }

}