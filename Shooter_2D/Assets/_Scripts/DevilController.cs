/*
Author: Sri Chatala
File : DavilController.cs
Created Date: Spe 25,2015
Descriptopn: Devil controller script controll the Devil gameObject
Laster Updated: Spe 25,2015
*/
using UnityEngine;
using System.Collections;
[System.Serializable]
public class Speed
{
    public float minSpeed, maxSpeed;

}

//[System.Serializable]
//public class Drift
//{
//    public float minDrift;
//    public float maxDrift;
//}
public class DevilController : MonoBehaviour {

    //Initialize the speed of the balloon
    public Speed speed;

    //public Drift drift;

    private float _CurrentSpeed;

 //   private float _CurrectDrift;
    // Use this for initialization
    void Start () {
        //call the reset method to move the balloon
        this._Reset();
    }
	
	// Update is called once per frame
	void Update () {
        Vector2 currentPosition = new Vector2(0.0f, 0.0f);
        currentPosition = gameObject.GetComponent<Transform>().position;

       // currentPosition.y += this._CurrectDrift;
        currentPosition.x -= this._CurrentSpeed;

        gameObject.GetComponent<Transform>().position = currentPosition;
        if (currentPosition.x <= -12.536)
        {
            this._Reset();
        }
    }
    private void _Reset()
    {
        //this._CurrectDrift = Random.Range(drift.minDrift, drift.maxDrift);
        this._CurrentSpeed = Random.Range(speed.minSpeed, speed.maxSpeed);
        Vector2 resetPosition = new Vector2(12.536f, Random.Range(-4.1f, 4.1f));
        gameObject.GetComponent<Transform>().position = resetPosition;
    }
}
