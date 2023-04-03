using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ASCIILevelLoadScript : MonoBehaviour
{
    public GameObject player;
    public GameObject wall;
    public GameObject spike;
    public GameObject door;
    
    GameObject currentPlayer;
    GameObject level;
    
    int currentLevel = 0;

    public int CurrentLevel
    {
        get { return currentLevel; }
        set
        {
            currentLevel = value;
            LoadLevel();
        }
    }

    const string FILE_NAME = "LevelNum.txt";
    const string FILE_DIR = "/Levels/";
    string FILE_PATH;

    public float xOffset;
    public float yOffset;

    public Vector2 playerStartPos;
    
    // Start is called before the first frame update
    void Start()
    {
        FILE_PATH = Application.dataPath + FILE_DIR + FILE_NAME;

        LoadLevel();
    }

    bool LoadLevel()
    {
        Destroy(level);
        
        level = new GameObject("Level");
        
        string newPath = FILE_PATH.Replace("Num", currentLevel + "");
        
        
        string[] fileLines = File.ReadAllLines(newPath);

       
        for (int yPos = 0; yPos < fileLines.Length; yPos++)
        {
            
            string lineText = fileLines[yPos];

           
            char[] lineChars = lineText.ToCharArray();

           
            for (int xPos = 0; xPos < lineChars.Length; xPos++)
            {
               
                char c = lineChars[xPos];

                
                GameObject newObj;

                switch (c)
                {
                    case 'A':  
                        playerStartPos = new Vector2(xOffset + xPos, yOffset - yPos);
                        newObj = Instantiate<GameObject>(player); 
                        currentPlayer = newObj;
                        break;
                    case 'D': 
                        newObj = Instantiate<GameObject>(wall); 
                        break;
                    case 'Q': 
                        newObj = Instantiate<GameObject>(spike); 
                        break;
                    case 'R':
                        newObj = Instantiate<GameObject>(door);
                        break;
                    default: 
                        newObj = null; 
                        break;
                }

              
                if (newObj != null)
                {
                   
                    newObj.transform.position =
                        new Vector2(
                            xOffset + xPos, 
                            yOffset - yPos);

                    newObj.transform.parent = level.transform;
                }
            }
        }

        return false;
    }

    public void ResetPlayer()
    {
        currentPlayer.transform.position = playerStartPos;
    }

    public void HitDoor()
    {
        Debug.Log("Triggered a door!");
        CurrentLevel++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
