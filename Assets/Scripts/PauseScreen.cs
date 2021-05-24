using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : MonoBehaviour
{
    public bool IsPaused = false;
    public bool OnPauseScreen = true;
    private void Update()
    {
        if (OnPauseScreen)
        {
            if (!IsPaused)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    FindObjectOfType<gameManager>().Pause();
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    FindObjectOfType<gameManager>().UnPause();
                }
            }
        }
        
    }
    public void NotOn_PausedScreen()
    {
        OnPauseScreen = false;
    }
    public void On_PauseScreen()
    {
        OnPauseScreen = true;
    }
}
