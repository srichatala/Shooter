using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public Vector2 move = new Vector2(0.0f, 0.0f);

    private Vector2 newPosition = new Vector2(0.0f, 0.0f);

	// Use this for initialization
	void Start () {
        Debug.Log("Player into screen");
	}
	
	// Update is called once per frame
	void Update () {
        newPosition = gameObject.GetComponent<Transform>().position;
        if (Input.GetAxis("Horizontal") > 0)
        {
            newPosition.x += this.move.x;
            gameObject.GetComponent<Transform>().position = newPosition;
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            newPosition.x -= this.move.x;
            gameObject.GetComponent<Transform>().position = newPosition;
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            newPosition.y += this.move.y;
            gameObject.GetComponent<Transform>().position = newPosition;
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            newPosition.y -= this.move.y;
            gameObject.GetComponent<Transform>().position = newPosition;
        }
    }
}
