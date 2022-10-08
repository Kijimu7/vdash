using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterFollow : MonoBehaviour
{
    private Transform player;
    private float distance;
    [SerializeField] float moveSpeed;
    [SerializeField] float howclose;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.position, transform.position);

        if(distance <= howclose)
        {
            transform.LookAt(player.transform);
            GetComponent<Rigidbody>().AddForce(transform.forward * moveSpeed);

        }

        //for melee attack or explosive
        if(distance <= 1.5f)
        {
            //do die
        }
    }
}
