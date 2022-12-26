using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public List<GameObject> BallTemplateList;
    public List<GameObject> BallList;

    public Transform SpawnArea;

    public int maxBall;
    public float spawnInterval;
    private float spawnTimer;

    public void SpawnBall()
    {
        int SpawnFrom = Random.Range(1, 5);
        SpawnBall(SpawnFrom);
    }

    public void SpawnBall(int SpawnNumber) // SpawnNumber adalah hasil random.range int
    {
        if (BallList.Count >= maxBall)
        {
            return;
        }

        if (SpawnNumber == 1)
        {
            GameObject ballObject = Instantiate(BallTemplateList[0], new Vector3(6.8f, 1.5f, -6.8f), Quaternion.identity, SpawnArea);
            ballObject.SetActive(true);
            BallList.Add(ballObject);
            ballObject.GetComponent<Rigidbody>().AddForce(-4, 0, 4, ForceMode.Impulse);
        }
        
        if (SpawnNumber == 2)
        {
            GameObject ballObject = Instantiate(BallTemplateList[0], new Vector3(6.8f, 1.5f, 6.8f), Quaternion.identity, SpawnArea);
            ballObject.SetActive(true);
            BallList.Add(ballObject);
            ballObject.GetComponent<Rigidbody>().AddForce(-4, 0, -4, ForceMode.Impulse);
        }
        
        if (SpawnNumber == 3)
        {
            GameObject ballObject = Instantiate(BallTemplateList[0], new Vector3(-6.8f, 1.5f, 6.8f), Quaternion.identity, SpawnArea);
            ballObject.SetActive(true);
            BallList.Add(ballObject);

            ballObject.GetComponent<Rigidbody>().AddForce(4, 0, -4, ForceMode.Impulse);
        }

        if (SpawnNumber == 4)
        {
            GameObject ballObject = Instantiate(BallTemplateList[0], new Vector3(-6.8f, 1.5f, -6.8f), Quaternion.identity, SpawnArea);
            ballObject.SetActive(true);
            BallList.Add(ballObject);
            ballObject.GetComponent<Rigidbody>().AddForce(4, 0, 4, ForceMode.Impulse);
        }
    }

    public void RemoveBall(GameObject ballObject) //GameObject ballObject
    {
        BallList.Remove(ballObject);
        Destroy(ballObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = 0;
        BallList = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer > spawnInterval)
        {
            SpawnBall();
            spawnTimer -= spawnInterval;
        }
    }
}
