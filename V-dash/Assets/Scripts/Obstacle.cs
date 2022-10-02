using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    CharController charController;
    // Start is called before the first frame update
    void Start()
    {
        charController = GameObject.FindObjectOfType<CharController>();
    }


    /*    private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {

                charController.Die();
            }
            //Kill the player
        }*/

    private void OnCollistionEnter(Collision collison)
    {
        if (collison.gameObject.CompareTag("Player")) { 
            charController.Die();
        }

        //Kill the player
    }

}
