using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplayici : MonoBehaviour
{
    [SerializeField]
    GameObject yildizPrefab;
    List<GameObject> yildizlar = new List<GameObject>();
    /// <summary>
    /// Hedefteki y�ld�z� s�yler
    /// </summary>
    public GameObject HedefYildiz
    {
        get
        {
            if(yildizlar.Count > 0)
            {
                return yildizlar[0];
            }
            else
            {
                return null;
            }
        }
    }
      

    
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            Vector3 oyunD�nyasiPozisyon = Camera.main.ScreenToWorldPoint(position);
            yildizlar.Add(Instantiate(yildizPrefab, oyunD�nyasiPozisyon, Quaternion.identity));
        }
    }

    /// <summary>
    /// parametre olarak g�nderilen y�ld�z� yok eder
    /// </summary>
    /// <param name="yokEdilecekYildiz"></param>
    public void yildizYokEt(GameObject yokEdilecekYildiz)
    {
        yildizlar.Remove(yokEdilecekYildiz);
        Destroy(yokEdilecekYildiz);
    }
}
