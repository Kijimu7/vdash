using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    RoadSpawner roadSpawner; //reference to the RoadSpaner class
    // Start is called before the first frame update
    void Start()
    {
        roadSpawner = GetComponent<RoadSpawner>();
    }

    public void SpawnTriggerEnter()
    {
        roadSpawner.MoveRoad();
    }
}
