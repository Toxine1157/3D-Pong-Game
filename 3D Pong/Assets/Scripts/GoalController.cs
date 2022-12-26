using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider ball;
    public bool isHorizontalAxis;
    public bool isPositiveAxis;
    public ScoreManager managerScore;

    public BallSpawner ballSpawner;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision == ball || collision.gameObject.name == "Ball(Clone)")
        {
            if (isHorizontalAxis == true && isPositiveAxis == true) // Player 4
            {
                managerScore.MinP4Score(1);
                ballSpawner.GetComponent<BallSpawner>().RemoveBall(collision.gameObject);
            }
            if (isHorizontalAxis == true && isPositiveAxis == false) // Player 3
            {
                managerScore.MinP3Score(1);
                ballSpawner.GetComponent<BallSpawner>().RemoveBall(collision.gameObject);
            }
            if (isHorizontalAxis == false && isPositiveAxis == true) // Player 2
            {
                managerScore.MinP2Score(1);
                ballSpawner.GetComponent<BallSpawner>().RemoveBall(collision.gameObject);
            }
            if (isHorizontalAxis == false && isPositiveAxis == false) // Player 1
            {
                managerScore.MinP1Score(1);
                ballSpawner.GetComponent<BallSpawner>().RemoveBall(collision.gameObject);
            }
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
