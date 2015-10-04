/*
Author: Sri Chatala
File : GameController.cs
Created Date: Oct 03,2015
Descriptopn: GameController script controll the Game Object
Laster Updated: Oct 03,2015
*/
using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    public int devilCount;
    public GameObject devil;
	// Use this for initialization
	void Start () {
        this._GenerateDevil();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    private void _GenerateDevil()
    {
        for(int count = 0; count < devilCount; count++)
        {
            Instantiate(devil);
        }
    }
}
