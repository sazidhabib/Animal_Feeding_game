using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int lives = 3;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddLive(int value)
    {
        lives += value;

        if(lives <= 0)
        {
            lives = 0;
            Debug.Log("Game Over");
        }
        Debug.Log("Lives: " + lives);
    }
    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score: " + score);
    }

    
}
