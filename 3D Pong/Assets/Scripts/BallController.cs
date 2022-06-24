using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed;
    private Rigidbody rig;
    //public int BallSpawnWhere;

    /*public void SpawnFrom(int BallSpawnWhere)
    {
        if (BallSpawnWhere == 1)
        {
            rig.AddForce(-4, 0, 4, ForceMode.Impulse);
        }

        if (BallSpawnWhere == 2)
        {
            rig.AddForce(-4, 0, -4, ForceMode.Impulse);
        }

        if (BallSpawnWhere == 3)
        {
            rig.AddForce(4, 0, -4, ForceMode.Impulse);
        }

        if (BallSpawnWhere == 4)
        {
            rig.AddForce(4, 0, 4, ForceMode.Impulse);
        }
    }*/

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player1")
        {
            rig.AddForce(Random.Range(-100, 101), 0, 0, ForceMode.Acceleration);
            //rig.velocity *= 1.05f;
            //rig.AddTorque(new Vector3(40f, 45f, 80f), ForceMode.Impulse);
        }

        if (collision.gameObject.name == "Player2")
        {
            rig.AddForce(Random.Range(-100, 101), 0, 0, ForceMode.Acceleration);
            //rig.velocity *= 1.05f;
            //rig.AddTorque(new Vector3(40f, 45f, 80f), ForceMode.Impulse);
        }
        
        if (collision.gameObject.name == "Player3")
        {
            rig.AddForce(0, 0, Random.Range(-100, 101), ForceMode.Acceleration);
            //rig.velocity *= 1.05f;
            //rig.AddTorque(new Vector3(40f, 45f, 80f), ForceMode.Impulse);
        }
        
        if (collision.gameObject.name == "Player4")
        {
            rig.AddForce(0, 0, Random.Range(-100, 101), ForceMode.Acceleration);
            //rig.velocity *= 1.05f;
            //rig.AddTorque(new Vector3(40f, 45f, 80f), ForceMode.Impulse);
        }

        if (collision.gameObject.name == "Ball(Clone)")
        {
            rig.AddForce(Random.Range(-300, 301), 0, Random.Range(-300, 301), ForceMode.Acceleration);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        //rig.velocity = speed;
        //SpawnFrom(BallSpawnWhere);
        //rig.AddForce(4, 0, 4, ForceMode.Impulse);
        //rig.maxAngularVelocity = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("move speed ball = " + rig.velocity);
    }
}
