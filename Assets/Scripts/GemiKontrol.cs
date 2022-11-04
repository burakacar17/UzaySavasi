using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemiKontrol : MonoBehaviour
{
    [SerializeField]
    GameObject kursunPrefab;
    
    [SerializeField]
    GameObject patlamaPrefab;

    const float hareketGücü = 5;

    OyunKontrolcusu oyunKontrolcusu;
    
    void Start()
    {
        oyunKontrolcusu = Camera.main.GetComponent<OyunKontrolcusu>();
    }

    
    void Update()
    {
        Vector3 position = transform.position;
        float yatayInput = Input.GetAxis("Horizontal");
        float dikeyInput = Input.GetAxis("Vertical");

        if (yatayInput != 0)
        {

            position.x += yatayInput * hareketGücü * Time.deltaTime;
        }

        if (dikeyInput != 0)
        {
            position.y += dikeyInput * hareketGücü * Time.deltaTime;
        }

        transform.position = position;

        if (Input.GetButtonDown("Jump"))
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<SesKontrol>().Ates();
            Vector3 kursunPosition = gameObject.transform.position;
            kursunPosition.y += 1;


            Instantiate(kursunPrefab, kursunPosition, Quaternion.identity);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Asteroid")
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<SesKontrol>().GemiPatlama();
            oyunKontrolcusu.OyunuBitir();
            Instantiate(patlamaPrefab, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
