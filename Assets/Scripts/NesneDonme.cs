using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NesneDonme : MonoBehaviour
{
    public  float hiz  = 0.02f ;
    void Start()
    {
        
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(hiz, hiz, hiz));
    }
}
