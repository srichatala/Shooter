/*
Author: Sri Chatala
File : PalyerController.cs
Created Date: Spe 24,2015
Descriptopn: Player controller script controll the player gameObject
Laster Updated: Spe 25,2015
*/

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public Vector2 Speed = new Vector2(50, 50);
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(Speed.x * inputX, Speed.y * inputY);

        movement *= Time.deltaTime;

        transform.Translate(movement);
	}
}
