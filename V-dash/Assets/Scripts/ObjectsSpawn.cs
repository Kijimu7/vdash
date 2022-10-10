using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsSpawn : MonoBehaviour
{
    //public GameObject obstaclePrefab;
    public List<GameObject> obstaclePrefabs;
    [SerializeField] GameObject coinPrefab;
    //[SerializeField] GameObject donutPrefab;
    public Vector3 firstPostion;
    public float gap = 2;
    private Transform donut;

    private void Start()
    {
        SpawnObstacle();
        obstaclePrefabs = new List<GameObject>();

        SpawnCoins();
        StartCoroutine(SpawnCoins());
        
    }


    void SpawnObstacle()
    {
       
             // Choose a random point to spawn the obstacle
            int obstacleSpawnIndex = Random.Range(0, 3);
            //int donutSpawnIndex = 19;
            Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;// get ObstacleSpawn left, middle right component transform
                                                                                    //Transform donutSpawnPoint = transform.GetChild(donutSpawnIndex).transform; 

            //Spawn the obstacle at the postion
            //donut = transform.FindChild("DonutMiddle");
            int n = Random.Range(0, 3); //obstacle objects
            Instantiate(obstaclePrefabs[n], spawnPoint.position, Quaternion.identity, transform);
           // Instantiate(donutPrefab, donut.position, donut.transform.rotation);
           // Debug.Log("donut " + donutPrefab);
                   
    }



    IEnumerator SpawnCoins()
    {      
        int coinToSpawn = 2;
        //Vector3 position = firstPostion;
        while (true) { 
        yield return new WaitForSeconds(5f);
        for (int i = 0; i< coinToSpawn; i++) { 
        int coinSpawnIndex = Random.Range(4, 15);
        Transform coinSpawnPoint = transform.GetChild(coinSpawnIndex).transform;
            Instantiate(coinPrefab, coinSpawnPoint.position, Quaternion.identity, transform);
            //position.z += gap;
            //Debug.Log(i);
            }
        }

        // get ObstacleSpawn left, middle right component transform
        //Spawn the obstacle at the postion
        //int coinSpawn = Random.Range(4, 16);
     /*   int coinToSpawn = 10;
        for(int i = 0; i< coinToSpawn; i++)
        {
        Instantiate(coinPrefab, coinSpawnPoint.position, Quaternion.identity, transform);

        }*/
    }

    /*   void SpawnCoins()
       {
           int coinsToSpawn = 10;
           for (int i = 0; i <coinsToSpawn; i++)
           {
               GameObject temp = Instantiate(coinPrefab, transform);
               temp.transform.position = new Vector3(Random.Range(-2, 3), 0.5f, 10.5f);

               //temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
           }
       }*/

    void GetRandomPointInCollider()
    {
        
    }

   /* Vector3 GetRandomPointInCollider(Collider collider)
    {
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z)
            );
        if(point != collider.ClosestPoint(point))
        {
            point = GetRandomPointInCollider(collider);
        }

        point.y = 1;
        return point;
    }*/

}
