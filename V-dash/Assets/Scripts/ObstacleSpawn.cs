using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject obstaclePrefab;
   
    private void Start()
    {
        SpawnObstacle();
        
    }

    void SpawnObstacle()
    {
        // Choose a random point to spawn the obstacle
        int obstacleSpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform; // get ObstacleSpawn left, middle right component transform


        //Spawn the obstacle at the postion
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }

}
