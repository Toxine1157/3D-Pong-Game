using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public KeyCode PauseKey;
    public KeyCode UnpauseKey;
    private Canvas cnv;
    //private bool pausemode;

    public void RestartGame()
    {
        SceneManager.LoadScene("Gameplay");
        Time.timeScale = 1;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void PauseGame()
    {
        if(/*pausemode == false &&*/ Input.GetKeyDown(PauseKey))
        {
            //if (Input.GetKeyDown(PauseKey))
            //{
            Time.timeScale = 0;
            cnv.enabled = true;
            //pausemode = true;
            //Debug.Log("Pausemode = " + pausemode);
            //}
        }

        if(/*pausemode == true &&*/ Input.GetKeyDown(UnpauseKey))
        {
            //if (Input.GetKeyDown(PauseKey))
            //{
            Time.timeScale = 1;
            cnv.enabled = false;
            //pausemode = false;
            //Debug.Log("Pausemode = " + pausemode);
            //}
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        //pausemode = false;
        cnv = GetComponent<Canvas>();
        //cnv.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        PauseGame();
    }
}
