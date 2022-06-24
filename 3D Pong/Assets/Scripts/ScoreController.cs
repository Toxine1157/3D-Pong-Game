using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text ScoreP1;
    public Text ScoreP2;
    public Text ScoreP3;
    public Text ScoreP4;

    public ScoreManager managerScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreP1.text = managerScore.P1Score.ToString();
        ScoreP2.text = managerScore.P2Score.ToString();
        ScoreP3.text = managerScore.P3Score.ToString();
        ScoreP4.text = managerScore.P4Score.ToString();
    }
}
