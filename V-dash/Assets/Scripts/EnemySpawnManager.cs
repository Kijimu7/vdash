using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    [SerializeField] private Transform enemyPosition;
    [SerializeField] private GameObject enemyPrefab;

    private void Start()
    {
       
    }
 

    private void OnTriggerEnter(Collider other)

    {
                
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject enemy = ObjectPool.instance.GetPooledObject();
            //gameObject.SetActive(false);
            if (enemy != null)
            {
                //enemy.transform.position = enemyPosition.position;
                enemy.transform.position = enemyPosition.forward * 30;

                enemy.SetActive(true);
            }
            Debug.Log("player enter");

        }


    }

}
