using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float forceAmount = 5; 
    
    Rigidbody2D rb2D; 
    

    
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            rb2D.AddForce(Vector2.up * forceAmount); 
        }

        if (Input.GetKey(KeyCode.S)) 
        {
            rb2D.AddForce(Vector2.down * forceAmount); 
        }

        if (Input.GetKey(KeyCode.A)) 
        {
            rb2D.AddForce(Vector2.left * forceAmount);
        }

        if (Input.GetKey(KeyCode.D)) 
        {
            rb2D.AddForce(Vector2.right * forceAmount); 
        }
        
        
    }
}
