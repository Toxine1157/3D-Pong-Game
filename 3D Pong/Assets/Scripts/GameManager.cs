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
        if(Input.GetKeyDown(PauseKey))
        {
            Time.timeScale = 0;
            cnv.enabled = true;
        }

        if(Input.GetKeyDown(UnpauseKey))
        {
            Time.timeScale = 1;
            cnv.enabled = false;
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        cnv = GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        PauseGame();
    }
}
