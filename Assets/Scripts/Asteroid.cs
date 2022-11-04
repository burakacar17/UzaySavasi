using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField]
    GameObject patlamaPrefab;
    OyunKontrolcusu oyunKontrolcusu;


    
    void Start()
    {
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        oyunKontrolcusu = Camera.main.GetComponent<OyunKontrolcusu>();

        float yon = Random.Range(0f, 1.0f);
        if(yon < 0.5)
        {
            rb2d.AddForce(new Vector2(Random.Range(-2.5f, -1.0f), Random.Range(-2.5f, -1.0f)), ForceMode2D.Impulse);
            rb2d.AddTorque(yon * 10.0f);
        }
        else
        {

            rb2d.AddForce(new Vector2(Random.Range(1.0f,2.5f), Random.Range(-2.5f,-1.0f)), ForceMode2D.Impulse);
            rb2d.AddTorque(-yon * 10.0f);
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Kursun")
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<SesKontrol>().AsteroidPatlama();
            oyunKontrolcusu.AsteroidYokOldu(gameObject);
            AsteroidYokEt();
            
        }
    }

    public void AsteroidYokEt()
    {
        Instantiate(patlamaPrefab, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
