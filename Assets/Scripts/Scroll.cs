using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    Material material; // background image
    Vector2 offset;
    public float xVelocity, yVelocity;
    

    private void Awake()
    {
        // get the background image 
        material = GetComponent<Renderer>().material;
    }

    void Start()
    {
        // defining the offset as moving a Vector 2 
        offset = new Vector2(xVelocity, yVelocity);   
    }


    void Update()
    {
        // moves the background unsing offset x time
        material.mainTextureOffset += offset * Time.deltaTime;
    }
}
