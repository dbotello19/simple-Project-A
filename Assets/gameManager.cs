﻿using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;
public class gameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public GameObject PauseScreenUI;
    public GameObject FailLevelUI;

    [HideInInspector]
    public Rigidbody rb;

    public void CompleteLevel()
    {
        /*if (!GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().Level01Completed)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().Level01Completed = true;

        }*/


        GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().SavePlayer();
       
        FindObjectOfType<PauseScreen>().OnPauseScreen = false;
        Cursor.visible = true;
        gameHasEnded = true;
        completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {

        FindObjectOfType<PauseScreen>().OnPauseScreen = false;
        if (!gameHasEnded)
        {
            Cursor.visible = true;
            gameHasEnded = true;
            FailLevelUI.SetActive(true);
            ResetPlayerPostion();
            
        }
    }

    public void Restart()
    {
        Cursor.visible = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Pause()
    {
        Cursor.visible = true;
        FindObjectOfType<PauseScreen>().IsPaused = true;
        PauseScreenUI.SetActive(true);
        FindObjectOfType<CameraMovement>().enabled = false;
        Time.timeScale = 0;


    }
    public void UnPause()
    {
        Cursor.visible = false;
        FindObjectOfType<PauseScreen>().IsPaused = false;
        PauseScreenUI.SetActive(false);
        FindObjectOfType<CameraMovement>().enabled = true;
        Time.timeScale = 1;
    

    }

    private void Awake()
    {
        rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
        ResetPlayerPostion();
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().isKinematic = true;
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().useGravity = false;
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().isKinematic = false;
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().useGravity = true;
    }

    private void FixedUpdate()
    {
        if (rb.position.y < -2)
        {
            FindObjectOfType<gameManager>().EndGame();
        }
    }
    void ResetPlayerPostion()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position = new Vector3(-27.49f, 2.35f, 26.57f);
    }

}
