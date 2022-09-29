using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollaBall : MonoBehaviour
{
    private Rigidbody Rigidbody;
    [SerializeField] float speed;
    Vector3 lastVelocity;
    
 


    //public Vector3 direction;

    void Start()
    {
       Rigidbody = gameObject.GetComponent<Rigidbody>();
        //direction = (new Vector3(Random.Range(-3.5f, 3.5f), 0.0f, Random.Range(6f, 6f))).normalized;
       
    }

 

    // Update is called once per frame
    void FixedUpdate()
    {
        //lastVelocity = Rigidbody.velocity;
        Rigidbody.AddForce(Vector3.right * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        var speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);

        Rigidbody.velocity = direction * Mathf.Max(speed, 0f);

    }
}
