using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        UzayGemisi gemi1 = new UzayGemisi(Random.Range(80,100));
        UzayGemisi gemi2 = new UzayGemisi(Random.Range(80,100),"Gri");

        gemi1.Yavaslatici();
        gemi2.Yavaslatici();

        if(gemi1.MaksimumHiz > gemi2.MaksimumHiz)
        {
            Debug.Log("Gemi 1 Kazand� ...");
        }else if(gemi2.MaksimumHiz > gemi1.MaksimumHiz)
        {
            Debug.Log("Gemi2 Kazand� ...");
        }
        else
        {
            Debug.Log("Berabere ...");
        }



        //int saldiranDusman = 10;
        //bool saldiriDevam = false;

        //while (saldiriDevam)
        //{
        //    saldiranDusman--;
        //    if(saldiranDusman < 3)
        //    {
        //        saldiriDevam = false;
        //    }

        //    Debug.Log("Sald�r� alt�nday�z. D��man say�s�: " + saldiranDusman);
        //}

        //do
        //{
        //    saldiranDusman--;
        //    if (saldiranDusman < 3)
        //    {
        //        saldiriDevam = false;
        //    }

        //    Debug.Log("Sald�r� alt�nday�z. D��man say�s�: " + saldiranDusman);
        //} while (saldiriDevam);



        //int yokEdilenAsteroid = 5;
        //int oyuncuHp = 100;

        //if(yokEdilenAsteroid >= 10 || oyuncuHp >= 80)
        //{
        //    Debug.Log("�ok G�zel");
        //}



        //if (yokEdilenAsteroid == 20)
        //{
        //    Debug.Log("Kazand�n�z");
        //}
        //else if(yokEdilenAsteroid == 25)
        //{
        //    Debug.Log("Tebrikler 1. Oldunuz");
        //}
        //else
        //{
        //    Debug.Log("Malesef Kaybettiniz");
        //}

        //switch (yokEdilenAsteroid)
        //{
        //    case 1:
        //        Debug.Log("G�zel ba�lang��");
        //        break;
        //    case 10:
        //        Debug.Log("Bu i�te �ok iyisin!");
        //        break;
        //    default:
        //        Debug.Log("Malesef Oyunu Kaybettiniz");
        //        break;
        //}







    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
