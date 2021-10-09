using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //uses unity ui system 

public class Score : MonoBehaviour
{


    public Text ScoreText;
    private GameObject pc;
    private int phealth;
    private bool isDead = false;
    public int pscore = 0;
    private bool OnTimer = false;
    private float timerset = 0.0f;
    private float timerMax = 0.3f;


    void Start()
    {
        // finds the scientist object 
        pc = GameObject.Find("Scientist");
    }


    /// <summary>
    /// here we caused the score to add every second and also track how much health the player has to stop the 
    /// score being given if the player is dead. This does this in a variety of different funtions which are to do with the creation
    /// of the timer. Which in turn stops the score going up differently dependent on the device used
    /// </summary>
    void Update()
    {
        timerset = timerset += Time.deltaTime;
        phealth = pc.GetComponent<Player>().health;
        CheckIfDead();
        AddScore();
        TimerChecker();
    }

    void TimerOn()
    {
       
        OnTimer = true;
       
    }

    void TimerChecker()
    {
        if (timerset >= timerMax)
        {
            OnTimer = false;
            timerset = 0.0f;
        }
    }
  

    void CheckIfDead()
    {
        if(phealth > 0)
        {
            isDead = false;
        }
        else
        {
            isDead = true;
        }
    }
    void AddScore()
    {
        if (!OnTimer)
        {
            if (!isDead)
            {
                pscore = pscore + 1;
                ScoreText.text = pscore.ToString();
                TimerOn();
            }
            else
            {
                ScoreText.text = pscore.ToString();
            }
        }
        else
        {

        }
        
    }
}
