using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin : MonoBehaviour
{
    public float turnSpeed = 90f;
    private void OnTriggerEnter(Collider other)
    {
        //Check that the object we collided with is the player
        if (!other.gameObject.CompareTag("Player"))
        {
          
            return;
        }

        // Add to the player's score
        GameManager.inst.IncrementScore();

        // Desroy this coin object
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, turnSpeed * Time.deltaTime, 0); //rotate the coin z-axis by 90 degree every sencods
    }
}
