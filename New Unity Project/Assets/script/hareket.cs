using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hareket : MonoBehaviour
{
    public GameObject kuyruk;
    List<GameObject> kuyruklar;

    Vector3 eskiKoordinat;
    GameObject eskiKuyruk;

    float hiz = 0.3f;

    public GameObject bitti_pnl;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "duvar")
        {
            bitti_pnl.SetActive(true);
            Time.timeScale = 0.0f;
        }

        if (other.gameObject.tag == "kuyruk")
        {
            bitti_pnl.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }



    public void tekrarOyna()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Scenes/levelBir");

    }



    void Start()
    {

        kuyruklar = new List<GameObject>();

        for (int i = 0; i < 5; i++)
        {
            GameObject yeniKuyruk = Instantiate(kuyruk, transform.position, Quaternion.identity);
            kuyruklar.Add(yeniKuyruk);
        }


        InvokeRepeating("hareketEt", 0.0f, 0.1f);

    }



    void hareketEt()
    {

        eskiKoordinat = transform.position;


        //  Bu kod güncel Unity versiyonlarýnda istediðimiz þekilde çalýþmadýðýndan sildik ve yerine aþaðýdaki kodu yazdýk "transform.Translate(0, 0, hiz * Time.deltaTime);"


        transform.position += transform.forward * hiz;

        kuyrukTakip();

    }



    public void kuyrukArttir()
    {
        GameObject yeniKuyruk = Instantiate(kuyruk, transform.position, Quaternion.identity);
        kuyruklar.Add(yeniKuyruk);
    }





    void kuyrukTakip()
    {
        kuyruklar[0].transform.position = eskiKoordinat;

        eskiKuyruk = kuyruklar[0];
        kuyruklar.RemoveAt(0);
        kuyruklar.Add(eskiKuyruk);
    }




    public void dondur(float aci)
    {
        transform.Rotate(0, aci, 0);
    }
}

