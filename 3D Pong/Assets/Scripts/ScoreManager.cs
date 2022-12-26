using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int P1Score;
    public int P2Score;
    public int P3Score;
    public int P4Score;

    public GoalController g1;
    public GoalController g2;
    public GoalController g3;
    public GoalController g4;

    public PaddleControllerHorizontal P1;
    public PaddleControllerHorizontal P2;
    public PaddleControllerVertical P3;
    public PaddleControllerVertical P4;

    public string Win;
    public WinnerCanvas Wcanvas;

    public void MinP1Score(int decrement)
    {
        P1Score -= decrement;
        if (P1Score <= 0)
        {
            g1.GetComponent<MeshRenderer>().enabled = true;
            g1.GetComponent<BoxCollider>().isTrigger = false;
            P1.GetComponent<MeshRenderer>().enabled = false;
            P1.GetComponent<BoxCollider>().enabled = false;
            P1.GetComponent<PaddleControllerHorizontal>().isAlive = false;

            isGameOver();
        }
    }

    public void MinP2Score(int decrement)
    {
        P2Score -= decrement;
        if (P2Score <= 0)
        {
            g2.GetComponent<MeshRenderer>().enabled = true;
            g2.GetComponent<BoxCollider>().isTrigger = false;
            P2.GetComponent<MeshRenderer>().enabled = false;
            P2.GetComponent<BoxCollider>().enabled = false;
            P2.GetComponent<PaddleControllerHorizontal>().isAlive = false;

            isGameOver();
        }
    }

    public void MinP3Score(int decrement)
    {
        P3Score -= decrement;
        if (P3Score <= 0)
        {
            g3.GetComponent<MeshRenderer>().enabled = true;
            g3.GetComponent<BoxCollider>().isTrigger = false;
            P3.GetComponent<MeshRenderer>().enabled = false;
            P3.GetComponent<BoxCollider>().enabled = false;
            P3.GetComponent<PaddleControllerVertical>().isAlive = false;

            isGameOver();
        }
    }

    public void MinP4Score(int decrement)
    {
        P4Score -= decrement;
        if (P4Score <= 0)
        {
            g4.GetComponent<MeshRenderer>().enabled = true;
            g4.GetComponent<BoxCollider>().isTrigger = false;
            P4.GetComponent<MeshRenderer>().enabled = false;
            P4.GetComponent<BoxCollider>().enabled = false;
            P4.GetComponent<PaddleControllerVertical>().isAlive = false;

            isGameOver();
        }
    }
    
    public void isGameOver()
    {
        // red win
        if (P1Score > 0 &&
            P2Score <= 0 &&
            P3Score <= 0 &&
            P4Score <= 0)
        {
            Wcanvas.GetComponent<Canvas>().enabled = true;
            Win = "Red is The Winner";
        }

        // yellow win
        if (P1Score <= 0 &&
            P2Score > 0 &&
            P3Score <= 0 &&
            P4Score <= 0)
        {
            Wcanvas.GetComponent<Canvas>().enabled = true;
            Win = "Yellow is The Winner";
        }

        //green win
        if (P1Score <= 0 &&
            P2Score <= 0 &&
            P3Score > 0 &&
            P4Score <= 0)
        {
            Wcanvas.GetComponent<Canvas>().enabled = true;
            Win = "Green is The Winner";
        }

        // blue win
        if (P1Score <= 0 &&
            P2Score <= 0 &&
            P3Score <= 0 &&
            P4Score > 0)
        {
            Wcanvas.GetComponent<Canvas>().enabled = true;
            Win = "Blue is The Winner";
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
