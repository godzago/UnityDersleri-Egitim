using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Degiskenler : MonoBehaviour
{
    int yas = 2;
    int puan = 10;

    float hiz = 50;
    float yukseklik = 1.8f;

    string isim;
    string mesaj = "Merhaba, ho� geldin!";

    bool kap�Acik = true;
    bool oyunBitti = false;

    public TextMeshProUGUI text01;

    string kazanantak�m = "FENERBAH�E KAZANAN TAKIM";

    string kazanantak�mv2 = "GALATASARAY KAZANAN TAKIM";

    int fenerbah�e = 50;
    int galatasaray = 51;

    int sonuc;

    char cisiyet = 'E';


    private void Start()
    {
        isim = "Mustaf Sandal";

        fenerbah�e++;
        galatasaray--;

        if (hiz > 25)
        {
            kap�Acik = false;
        }

        Debug.Log("KAPI DURUMU : " + kap�Acik);
    }



    //public int yas = 24;

    //public string mesaj;

    //public TextMeshProUGUI text;

    //public void Start()
    //{
    //    if (yas == 24)
    //    {
    //        text.text = mesaj.ToString();
    //    }
    //}
}
