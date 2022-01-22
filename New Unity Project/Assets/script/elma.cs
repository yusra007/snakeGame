using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class elma : MonoBehaviour
{


    public TextMeshProUGUI skor_txt;

    int skor = 0;

    hareket kuyrukOlustur;

    private void Start()
    {
        kuyrukOlustur = GameObject.Find("bas").GetComponent<hareket>();
    }


    // z 8, -2   X  12   -12

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "bas")
        {
            skor += 10;
            skor_txt.text = "SKOR " + skor;

            koordinatDegistir();

            kuyrukOlustur.kuyrukArttir();

        }


        if (other.gameObject.tag == "kuyruk")
        {
            koordinatDegistir();
        }
    }


    void koordinatDegistir()
    {
        float x_deger = Random.Range(-12.0f, 12.0f);
        float z_deger = Random.Range(-2.0f, 8.0f);

        transform.position = new Vector3(x_deger, 0, z_deger);
    }
}




