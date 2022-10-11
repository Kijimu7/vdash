using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rolling : MonoBehaviour
{

    //[SerializeField] float moveSpeed;
    //private Rigidbody Rigidbody;
    public int length = 3;
    private Transform attacher;
   

    private void Start()
    {
        //Rigidbody = gameObject.GetComponent<Rigidbody>();
        attacher = this.transform.Find("CandyBall");
    }
    // Update is called once per frame
    void Update()
    {
        //Rigidbody.AddForce(transform.right * moveSpeed);
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * 3, length), transform.position.z);
    }
}
