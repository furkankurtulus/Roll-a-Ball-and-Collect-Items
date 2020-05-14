using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallControl : MonoBehaviour
{
    Rigidbody fizik;
    public int hız;
    int sayac = 0;

    public int toplanilacakObjeSayisi;

    public Text sayacText;
    public Text oyunbittiText;
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        
    }

    
    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 hareket = new Vector3(yatay,0,dikey);
        fizik.AddForce(hareket*hız);


    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "küp")
        {
            other.gameObject.SetActive(false);
            sayac++;
            sayacText.text = "Sayac =" + sayac;

            if (sayac==toplanilacakObjeSayisi)
            {
                oyunbittiText.text = "Oyun Bitti";

            }
        }

    }
}
