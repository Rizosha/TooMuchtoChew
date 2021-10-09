using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Healthbarhandler : MonoBehaviour
{

    private int phealth;
    private GameObject health1;
    private GameObject health2;
    private GameObject health3;

    private GameObject pc;

    /// <summary>
    /// Here is the script that displays how much health the player has. This depends on how  much health we have left starting from 3
    /// each one then deactivates the appropriate health and also makes way for a additional health pick up we could implement
    /// </summary>

    void Start()
    {
 
        health1 = GameObject.Find("Health1");
        health2 = GameObject.Find("Health2");
        health3 = GameObject.Find("Health3");
        pc = GameObject.Find("Scientist");
    }

    void Update()
    {
        phealth = GameObject.Find("Scientist").GetComponent<Player>().health;
        if (phealth == 3)
        {
            health1.SetActive(true);
            health2.SetActive(true);
            health3.SetActive(true);
        }
        if(phealth == 2)
        {
            health1.SetActive(true);
            health2.SetActive(true);
            health3.SetActive(false);
        }
        if(phealth == 1)
        {
            health1.SetActive(true);
            health2.SetActive(false);
            health3.SetActive(false);
        }
        if(phealth == 0)
        {
            health1.SetActive(false);
            health2.SetActive(false);
            health3.SetActive(false);
            pc.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            print("you are dead");

        }
    }
}
