using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin : MonoBehaviour
{
    public float turnSpeed = 90f;
    public AudioClip coinSound;
    public static int coinScore;
    public static Coin instanciateCoin;


    private void Awake()
    {
        instanciateCoin = this;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(this.gameObject);
           
        }
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Destroy(this.gameObject);

        }
        //Check that the object we collided with is the player
        if (!other.gameObject.CompareTag("Player"))
        {
            return;
        }

        
        // Add to the player's score
        coinScore = GameManager.inst.score += 10;

        AudioSource.PlayClipAtPoint(coinSound, transform.position, 0.5f);
        // Desroy this coin object
        Destroy(this.gameObject);

    
    }


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, turnSpeed * Time.deltaTime, 0); //rotate the coin z-axis by 90 degree every sencods
        
    }
}
