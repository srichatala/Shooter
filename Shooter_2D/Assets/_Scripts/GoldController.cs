/*
Author: Sri Chatala
File : GoldController.cs
Created Date: Oct 03,2015
Descriptopn: GoldController controller script controll the Gold coin gameObject
Laster Updated: Oct 03,2015
*/

using UnityEngine;
using System.Collections;

public class GoldController : MonoBehaviour {
    //Public variables
    public float speed;
    // Use this for initialization
    void Start () {
        this._Reset();
    }
	
	// Update is called once per frame
	void Update () {
        Vector2 currentPosition = new Vector2(0.0f, 0.0f);
        currentPosition = gameObject.GetComponent<Transform>().position;
        currentPosition.x -= speed;

        // move the gameObject to the currentPosition
        gameObject.GetComponent<Transform>().position = currentPosition;

        // top boundary check - gameObject meets top of camera viewport
        if (currentPosition.x <= -12.1f)
        {
            this._Reset();
        }
    }
    // Resets our gameObject
    private void _Reset()
    {
        Vector2 resetPosition = new Vector2(12.1f,Random.Range(-4f, 4f));
        gameObject.GetComponent<Transform>().position = resetPosition;
    }
}
