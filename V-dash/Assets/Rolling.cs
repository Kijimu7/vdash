using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rolling : MonoBehaviour
{

    //[SerializeField] float moveSpeed;
    //private Rigidbody Rigidbody;
    public int length = 6;
    public float travelDistance;
    private Transform attacher;
    
    Vector3 startPosition;
   

    private void Start()
    {
        //Rigidbody = gameObject.GetComponent<Rigidbody>();
        attacher = this.transform.Find("CandyBall");
        startPosition = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        //Rigidbody.AddForce(transform.right * moveSpeed);
        transform.position = new Vector3(startPosition.x - Mathf.PingPong(Time.time * 2, travelDistance),transform.position.y, transform.position.z);
    }
}
