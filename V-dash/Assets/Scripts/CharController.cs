using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    public SpawnManager spawnManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SpawnTrigger")) {
        spawnManager.SpawnTriggerEnter();
        Debug.Log("Trigger Entered");
        }
    }
}
