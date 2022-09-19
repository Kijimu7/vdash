using BNG;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class CharController : MonoBehaviour
{
    bool alive = true;//player alive boolean
    public SpawnManager spawnManager;
    private Vector3 direction;
    private float forwardSpeed = 0f;
    CharacterController cc;
    private int desireLane = 1;
    public float laneDistance;
    public GameObject gameObjectToActivate;
    UImenuInGame uImenuInGame;
    private float spawnDistance = 1f;
    public Transform head;


    private void Awake()
    {
        cc = GetComponent<CharacterController>();

    }

    void Update()
    {
        
        direction.z = forwardSpeed; //set to move z direction
        cc.Move(direction * Time.deltaTime); //Move to z direction where specific amount input from forwardSpeed
       

        if (!alive) return;



        /*   if (InputBridge.Instance.XButtonDown)
           {
               transform.position = transform.position - new Vector3(3, 0, 0);
               Debug.Log("Thumb pressed");

               desireLane++;
               if (desireLane == 3)
                   desireLane = 2;
           }
           if (Input.GetKeyDown(KeyCode.D))
           {
               desireLane--;
               if (desireLane == -1)
                   desireLane = 0;
           }

           Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;

           if (desireLane == 0)
           {
               targetPosition += Vector3.left * laneDistance;
           }
           else
               if (desireLane == 2)
           {
               targetPosition = targetPosition += Vector3.right * laneDistance;
           }

           {
               transform.position = targetPosition;
           }
   */

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Die();
        }
    }

    public void Reset()
    {
        //Restart the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Die()
    {
        gameObjectToActivate.SetActive(true);
        gameObjectToActivate.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
        alive = false;
        Debug.Log("collide");
        //cc.enabled = false;         

       

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SpawnTrigger"))
        {
            spawnManager.SpawnTriggerEnter();

        }
    }

     
}
