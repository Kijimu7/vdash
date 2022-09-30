using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    [SerializeField] private Transform enemyPosition;
    //[SerializeField] private GameObject enemyPrefab;

    float x;
    float y;
    float z;
    Vector3 pos;

    private void Start()
    {
       
    }

    IEnumerator ExampleCoroutine()
    {

        while (true)
        {


            {

                yield return new WaitForSeconds(1);
                GameObject enemy = ObjectPool.instance.GetPooledObject();
                //gameObject.SetActive(false);
                if (enemy != null)
                {
                    //enemy.transform.position = enemyPosition.position;
                    x = Random.Range(-1, 5);
                    y = 2;
                    z = 30;
                    pos = new Vector3(x, y, z);
                    enemy.transform.position = pos;
                    //enemy.transform.position = enemyPosition.forward * 30;
                    enemy.SetActive(true);
                }
                Debug.Log("player enter");

            }
        }

    }

    private void OnTriggerEnter(Collider other)

    {
       
     
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(ExampleCoroutine());
        }

        


    }



}
