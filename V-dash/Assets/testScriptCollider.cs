using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScriptCollider : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Collider with cube");
        }
    }


}
