using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    public GameObject kuyruk;
    List<GameObject> kuyruklar;
    Vector3 eskiKoordinat;
    GameObject eskiKuyruk;
    float hiz = 45.0f;
    // Start is called before the first frame update
    void Start()
    {
        kuyruklar = new List<GameObject>();
        for (int i = 0; i < 10; i++)
        {
            GameObject yeniKuyruk = Instantiate(kuyruk, transform.position, Quaternion.identity);
            kuyruklar.Add(yeniKuyruk);
        }
        InvokeRepeating("hareketEt",0.0f,0.1f);
    }
    void hareketEt()
    {
        eskiKoordinat = transform.position;
       

        transform.Translate(0, 0, hiz * Time.deltaTime);
        kuyrukTakip();
          
    }
    void kuyrukTakip()
    { 
        kuyruklar[0].transform.position = eskiKoordinat;
        eskiKuyruk = kuyruklar[0];
                    kuyruklar.RemoveAt(0);
                    kuyruklar.Add(eskiKuyruk);

    }
    public dondur(float aci)
}
