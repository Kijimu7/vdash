using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyFollow : MonoBehaviour
{
    public Transform playerObj;//palyer
    public NavMeshAgent enemyMesh;//enemy
 /*   public int range;
    public int tetherRange;*/
    public Vector3 startPos;

    // Start is called before the first frame update
    /*    void Start()
        {
            InvokeRepeating("DistanceCheck", 0, 0.5f); //constantly run distance check function
            startPos = this.transform.position; //startpostion of the enemy
        }

        // Update is called once per frame
        void Update()
        {
           if(currentTarget != null)
            {
                myAgent.destination = currentTarget.transform.position;
            }
            else if(myAgent.destination != startPos)
            {
                myAgent.destination = startPos;
            }
        }

        public void DistanceCheck()
        {
            float dist = Vector3.Distance(this.transform.position, myTarget.transform.position);
            if (dist < range)
            {
                currentTarget = myTarget;
            }
            else if(dist > tetherRange)
            {
                currentTarget = null;
            }
        }
    }*/

    private void Start()
    {
        enemyMesh = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        enemyMesh.SetDestination(playerObj.position);
    }


}

