using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yokedici : MonoBehaviour
{
    [SerializeField]
    GameObject patlamaPrefab;
    GeriSayimSayaci yokEdiciGeriSayim;


    void Start()
    {
        yokEdiciGeriSayim = gameObject.AddComponent<GeriSayimSayaci>();
        

    }

    
    void Update()
    {
        if (yokEdiciGeriSayim.Bitti)
        {
            Instantiate(patlamaPrefab,gameObject.transform.position,Quaternion.identity);
            Destroy(gameObject);
            
        }
    }

    public void AsteroidYokEdici(int sure)
    {
        yokEdiciGeriSayim.ToplamSure = sure;
        yokEdiciGeriSayim.Calistir();
    }
}
