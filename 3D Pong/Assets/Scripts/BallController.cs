using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed;
    private Rigidbody rig;
    private AudioSource bounce;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player1")
        {
            rig.AddForce(Random.Range(-100, 101), 0, 0, ForceMode.Acceleration);
            bounce.Play();
        }

        if (collision.gameObject.name == "Player2")
        {
            rig.AddForce(Random.Range(-100, 101), 0, 0, ForceMode.Acceleration);
            bounce.Play();
        }
        
        if (collision.gameObject.name == "Player3")
        {
            rig.AddForce(0, 0, Random.Range(-100, 101), ForceMode.Acceleration);
            bounce.Play();
        }
        
        if (collision.gameObject.name == "Player4")
        {
            rig.AddForce(0, 0, Random.Range(-100, 101), ForceMode.Acceleration);
            bounce.Play();
        }

        if (collision.gameObject.name == "Ball(Clone)")
        {
            rig.AddForce(Random.Range(-300, 301), 0, Random.Range(-300, 301), ForceMode.Acceleration);
            bounce.Play();
        }

        if (collision.gameObject.name == "Spawner1" ||
            collision.gameObject.name == "Spawner2" ||
            collision.gameObject.name == "Spawner3" ||
            collision.gameObject.name == "Spawner4" ||
            collision.gameObject.name == "Goal1" ||
            collision.gameObject.name == "Goal2" ||
            collision.gameObject.name == "Goal3" ||
            collision.gameObject.name == "Goal4")
        {
            bounce.Play();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        bounce = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("move speed ball = " + rig.velocity);
    }
}
