using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
   
   
    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
      
    }
}
