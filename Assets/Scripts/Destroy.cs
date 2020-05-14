using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
  
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
    void OnTriggerEnter (Collider nesne)
    {
        if (nesne.gameObject.tag =="küp")
        {
            Destroy(nesne.gameObject);
        }
    }
}
