using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerControl : MonoBehaviour {

    private Rigidbody rb;
    public float hiz;
    public int sayac;
    public Text sayacText;
    public Text winText;

	void Start () {

        rb = GetComponent<Rigidbody>();   //<> bir sınıf array gibi  //rb=oyuncu,küre,player 
                                          //getcomponent sahnedeki nesneyi çekiyor
	}

    private void FixedUpdate()

{
        float yatay;
        float dikey;
        if (SystemInfo.deviceType == DeviceType.Desktop)
        { 
        //klavye bilgisi
         yatay = Input.GetAxis("Horizontal");
         dikey = Input.GetAxis("Vertical");
        }  
        else
        {
            yatay = Input.acceleration.x;
            dikey = Input.acceleration.y;
        } 
            //Vector3(x,y,z)
            //x: Hor
            //z: Ver
            //y: 0f
        
        Vector3 hareket = new Vector3(yatay, 0f, dikey);
        rb.AddForce(hareket*hiz);

    
    }


     void OnTriggerEnter(Collider other)  
    {
        if (other.gameObject.CompareTag("elmas"))
        {
           
            other.gameObject.SetActive(false);
            sayac+=5;
            sayacText.text ="Puan:" + sayac.ToString();

            if (sayac == 50)
            
                winText.text = "TEBRİKLER KAZANDINIZ! :)";
             
            
        }
    }
}
