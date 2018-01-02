using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraContol : MonoBehaviour {

    private Vector3 fark;
    public GameObject oyuncu;
    //fark = nesne.vector3 - camera.vector3
	void Start () {
        fark = transform.position - oyuncu.transform.position;
	}
	

    private void LateUpdate () {

        //hesaplanan fark kameranın position değerine ekliyor
        transform.position = oyuncu.transform.position + fark;

	}
}
