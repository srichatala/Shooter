/*
Author: Sri Chatala
File : Bullet.cs
Created Date: Oct 03,2015
Descriptopn: Bullet controller script controll the Bullet gameObject
Laster Updated: Spe 25,2015
*/
using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

    public float Speed;
    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * Speed;
    }
}
