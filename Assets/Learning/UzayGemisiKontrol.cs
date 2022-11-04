using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzayGemisiKontrol : MonoBehaviour
{

    const float hareketGücü = 5;
    bool topluyor = false;
    GameObject hedef;
    Rigidbody2D myRigidbody2D;
    Toplayici toplayici;
   
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        toplayici = Camera.main.GetComponent<Toplayici>();
    }

    private void OnMouseDown()
    {
        if (!topluyor)
        {
            GitVeTopla();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject == hedef)
        {
            toplayici.yildizYokEt(hedef);
            myRigidbody2D.velocity = Vector2.zero;
            GitVeTopla();
        }
    }

    void GitVeTopla()
    {
        hedef = toplayici.HedefYildiz;
        if(hedef != null)
        {
            Vector2 gidilecekYer = new Vector2(hedef.transform.position.x 
                - transform.position.x, hedef.transform.position.y - transform.position.y);
            gidilecekYer.Normalize();

            myRigidbody2D.AddForce(gidilecekYer * hareketGücü, ForceMode2D.Impulse);


        }
    }


    void Update()
    {
        //Vector3 position = transform.position;
        //float yatayInput = Input.GetAxis("Horizontal");
        //float dikeyInput = Input.GetAxis("Vertical");

        //if (yatayInput != 0){

        //    position.x += yatayInput * hareketGücü * Time.deltaTime; 
        //}

        //if(dikeyInput != 0)
        //{
        //    position.y += dikeyInput * hareketGücü * Time.deltaTime;
        //}

        //transform.position = position;
    }
}
