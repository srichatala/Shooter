/*
Author: Sri Chatala
File : Balloon.cs
Created Date: Spe 25,2015
Descriptopn: Balloon controller script controll the Balloon gameObject
Laster Updated: Spe 25,2015
*/
using UnityEngine;
using System.Collections;

public class BalloonController : MonoBehaviour {

    //Initialize the speed of the balloon
    public float Speed;
    // Use this for initialization
    void Start () {
        //call the reset method to move the balloon
        this._Reset();
    }
	
	// Update is called once per frame
	void Update () {
        Vector2 currentPosition = new Vector2(0.0f, 0.0f);
        currentPosition = gameObject.GetComponent<Transform>().position;
        currentPosition.x -= Speed;

        gameObject.GetComponent<Transform>().position = currentPosition;
        if (currentPosition.x <= -12)
        {
            this._Reset();
        }
    }
    private void _Reset()
    {
        Vector2 resetPosition = new Vector2(12f, 0.0f);
        gameObject.GetComponent<Transform>().position = resetPosition;
    }
}
