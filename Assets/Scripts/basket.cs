using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basket : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
            if (other.CompareTag("fruit"))
            {
                GameManager.Instance.AddScore(10);
               
            }
        
    }
}
