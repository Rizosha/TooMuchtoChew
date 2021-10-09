using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform FirePoint;
    private bool dab = true;
    private GameObject pellet;

    public GameObject pelletPrefab;
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && dab) //if "space" is pressed
        {

            Shoot(); 
            dab = false; 
            StartCoroutine(WaiterForKon()); //start waiting sequence
        }


    }

    void Shoot() //shoot a pellet prefab 
    {
        pellet = Instantiate(pelletPrefab, FirePoint.position, FirePoint.rotation);
    }
    IEnumerator WaiterForKon() //disables a function for x amount of time
    {
        yield return new WaitForSeconds(0.5f);
        dab = true;
    }


}
