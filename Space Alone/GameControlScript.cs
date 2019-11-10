using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScript : MonoBehaviour
{
    bool isRunning = true;
    public int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        Score++;
    }

    public void PlayerDied()
    {
        isRunning = false;
    }

    void OnGUI()
    {
        if(isRunning == true)
        {
            GUI.Label(new Rect(5, 5, 100, 30), "Points: " + Score);
        }
        else
        {
            GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "Game over. Total points: " + Score);
        }
    }
}
