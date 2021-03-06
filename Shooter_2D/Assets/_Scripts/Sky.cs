﻿/*
Author: Sri Chatala
File : Sky.cs
Created Date: Spe 24,2015
Descriptopn: Sky controller script controll the background of the game
Laster Updated: Oct 01,2015
*/


using UnityEngine;
using System.Collections;

public class Sky : MonoBehaviour {
    //Initialize the speed of the background
    public float Speed;
	// Use this for initialization
	void Start () {

        //call the reset method to move the background
        this._Reset();
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 currentPosition = new Vector2(0.0f, 0.0f);
        currentPosition = gameObject.GetComponent<Transform>().position;
        currentPosition.x -= Speed;

        gameObject.GetComponent<Transform>().position = currentPosition;
        if(currentPosition.x <= -23.5)
        {
            this._Reset();
        }
	}

    private void _Reset() {
        Vector2 resetPosition = new Vector2(23.5f, 0.0f);
        gameObject.GetComponent<Transform>().position = resetPosition;
    }
}
