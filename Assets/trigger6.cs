using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger6 : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    public Camera camera3;
    public Camera camera4;
    public Camera camera5;
    public Camera camera6;
    public Camera camera7;
    public Camera camera8;

    void OnTriggerEnter2D(Collider2D other){

        camera1.enabled = false;
        camera2.enabled = false;
        camera3.enabled = false;
        camera4.enabled = false;
        camera5.enabled = false;
        camera6.enabled = true;
        camera7.enabled = false;
        camera8.enabled = false;

    }
}
