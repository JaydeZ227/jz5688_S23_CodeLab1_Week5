using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTouch : MonoBehaviour
{
   
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("HIT: " + col.gameObject.name.Contains("Player"));
        
        if (col.gameObject.name.Contains("Player"))
        {
            GameManager.instance.GetComponent<ASCIILevelLoadScript>().ResetPlayer();
        }
    }
}
