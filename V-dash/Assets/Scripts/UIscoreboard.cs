using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class UIscoreboard : MonoBehaviour
{
    public GameObject uiPrefab;
    //public List<GameObject> uiPrefabs;
    public Transform head;
    private float spawnDistance = 8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      /*  foreach (GameObject obj in uiPrefabs)
        {
            obj.transform.position = head.position + new Vector3(head.forward.x, 0.3f, head.forward.z).normalized * spawnDistance;
        }*/
        uiPrefab.transform.position = head.position + new Vector3(head.forward.x, 0.2f, head.forward.z).normalized * spawnDistance;
    }

}
