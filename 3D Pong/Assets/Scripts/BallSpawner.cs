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

    //public BallController ballCtrl;

    /* use int Random.Range to give tags to spawner location 
    then return int to be used as parameter in spawner method
    */

    public void SpawnBall()
    {
        int SpawnFrom = Random.Range(3, 4);
        SpawnBall(SpawnFrom);
        //ballCtrl.GetComponent<BallController>().BallSpawnWhere = SpawnFrom;
    }

    public void SpawnBall(int SpawnNumber) // SpawnNumber adalah hasil random.range int
    {
        if (BallList.Count >= maxBall)
        {
            return;
        }

        if (SpawnNumber == 1)
        {
            //GameObject powerUp = Instantiate(powerUpTemplateList[randomIndex], new Vector3(position.x, position.y, powerUpTemplateList[randomIndex].transform.position.z), Quaternion.identity, spawnArea);
            //powerUp.SetActive(true);

            //powerUpList.Add(powerUp);//

            GameObject ballObject = Instantiate(BallTemplateList[0], new Vector3(6.8f, 1.5f, -6.8f), Quaternion.identity, SpawnArea);
            ballObject.SetActive(true);
            //ballObject.AddForce()
            BallList.Add(ballObject);

            ballObject.GetComponent<Rigidbody>().AddForce(-4, 0, 4, ForceMode.Impulse);//AddForce(new Vector3(-400, 0, -400));
        }
        
        if (SpawnNumber == 2)
        {
            GameObject ballObject = Instantiate(BallTemplateList[0], new Vector3(6.8f, 1.5f, 6.8f), Quaternion.identity, SpawnArea);
            ballObject.SetActive(true);
            //ballObject.AddForce(-1, 0, -1, ForceMode.Impulse);
            BallList.Add(ballObject);//

            ballObject.GetComponent<Rigidbody>().AddForce(-4, 0, -4, ForceMode.Impulse);//AddForce(new Vector3(-400, 0, -400));
        }
        
        if (SpawnNumber == 3)
        {
            GameObject ballObject = Instantiate(BallTemplateList[0], new Vector3(-6.8f, 1.5f, 6.8f), Quaternion.identity, SpawnArea);
            ballObject.SetActive(true);
            BallList.Add(ballObject);//

            ballObject.GetComponent<Rigidbody>().AddForce(4, 0, -4, ForceMode.Impulse);//velocity = new Vector3(-4, 0, 4);//AddForce(new Vector3(-400, 0, -400));
        }

        if (SpawnNumber == 4)
        {
            GameObject ballObject = Instantiate(BallTemplateList[0], new Vector3(-6.8f, 1.5f, -6.8f), Quaternion.identity, SpawnArea);
            ballObject.SetActive(true);
            BallList.Add(ballObject);//

            ballObject.GetComponent<Rigidbody>().AddForce(4, 0, 4, ForceMode.Impulse); //AddForce(new Vector3(-400, 0, -400)); 
        }
    }

    /*private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Goal1" ||
            collision.gameObject.name == "Goal2" ||
            collision.gameObject.name == "Goal3" ||
            collision.gameObject.name == "Goal4")
        {
            RemoveBall(BallList[0]);//BallList.Remove();
        }
    }*/

    public void RemoveBall(GameObject ballObject) //GameObject ballObject
    {
        BallList.Remove(ballObject);
        Destroy(ballObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = 0;
        //spawnInterval = 0;
        //
        BallList = new List<GameObject>();
        //SpawnBall();
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
