using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasifNesne : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {

    }
    void OnTriggerEnter(Collider nesne)
    {
        if (nesne.gameObject.tag == "küp")
        {
            nesne.gameObject.SetActive(false);
        }
    }
}
