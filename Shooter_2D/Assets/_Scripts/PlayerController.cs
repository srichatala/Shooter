/*
Author: Sri Chatala
File : PalyerController.cs
Created Date: Spe 24,2015
Descriptopn: Player controller script controll the player gameObject
Laster Updated: Spe 25,2015
*/

using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundaries
{
    public float minY, maxY;
}
public class PlayerController : MonoBehaviour {

    public float speed;
    public Boundaries boundary;
    private Vector2 _newPosition = new Vector2(0.0f, 0.0f);
    public Camera camera;

   void Update()
    {
        this._newPosition = gameObject.GetComponent<Transform>().position; // current position

        /*if (Input.GetAxis("Vertical") > 0)
        {
            this._newPosition.y += this.speed; // add move value to current position
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            this._newPosition.y -= this.speed; // subtract move value to current position
        }*/
        Vector2 mousePosition = Input.mousePosition;
        this._newPosition.y  = this.camera.ScreenToWorldPoint(mousePosition).y;

        this._BoundaryCheck();

        gameObject.GetComponent<Transform>().position = this._newPosition;
    }

    private void _BoundaryCheck()
    {
        if (this._newPosition.y < this.boundary.minY)
        {
            this._newPosition.y = this.boundary.minY;
        }

        if (this._newPosition.y > this.boundary.maxY)
        {
            this._newPosition.y = this.boundary.maxY;
        }
    }

}
