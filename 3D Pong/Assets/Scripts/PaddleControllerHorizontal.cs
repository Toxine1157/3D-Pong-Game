using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControllerHorizontal : MonoBehaviour
{
    public float speed;
    public KeyCode leftKey;
    public KeyCode rightKey;
    private Rigidbody rig;
    public bool isAlive;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //get input
        Vector3 movement = GetInput();
        //move object
        MoveObject(movement);
    }

    private Vector3 GetInput()
    {
        if (Input.GetKey(rightKey))
        {
            return transform.position += Vector3.right * Time.deltaTime * speed;
        }
        else if (Input.GetKey(leftKey))
        {
            return transform.position += Vector3.left * Time.deltaTime * speed;
        }

        return Vector3.zero;
    }

    //move object
    private void MoveObject(Vector3 movement)
    {
        //Debug.Log("TEST: " + movement);
        rig.velocity = movement;
    }
}
