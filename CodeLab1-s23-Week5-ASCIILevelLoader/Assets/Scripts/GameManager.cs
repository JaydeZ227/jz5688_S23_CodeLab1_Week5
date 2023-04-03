using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
 
    public static GameManager instance; 

    int currentLevel = 0;

    void Awake()
    {
        if (instance == null) 
        {
            DontDestroyOnLoad(gameObject);  
            instance = this;  
        }
        else  
        {
            Destroy(gameObject); 
        }
    }

 
    void Start()
    {
    }

  
    void Update()
    {
        
    }
}
