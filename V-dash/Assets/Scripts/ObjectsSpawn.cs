using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsSpawn : MonoBehaviour
{
    //public GameObject obstaclePrefab;
    public List<GameObject> obstaclePrefabs;
   
    private void Start()
    {
        SpawnObstacle();
        obstaclePrefabs = new List<GameObject>();
        SpawnCoins();
        
    }

    void SpawnObstacle()
    {
        // Choose a random point to spawn the obstacle
        int obstacleSpawnIndex = Random.Range(0, 3);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform; // get ObstacleSpawn left, middle right component transform


        //Spawn the obstacle at the postion
        int n = Random.Range(0, 3);
        Instantiate(obstaclePrefabs[n], spawnPoint.position, Quaternion.identity, transform);
    }
    public GameObject coinPrefab;

    void SpawnCoins()
    {
        int coinsToSpawn = 10;
        for (int i = 0; i <coinsToSpawn; i++)
        {
            GameObject temp = Instantiate(coinPrefab, transform);
            temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }

    Vector3 GetRandomPointInCollider(Collider collider)
    {
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.x, collider.bounds.max.y),
            Random.Range(collider.bounds.min.x, collider.bounds.max.z)
            );
        if(point != collider.ClosestPoint(point))
        {
            point = GetRandomPointInCollider(collider);
        }

        point.y = 1;
        return point;
    }

}
