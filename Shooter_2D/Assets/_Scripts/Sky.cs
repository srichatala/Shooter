using UnityEngine;
using System.Collections;

public class Sky : MonoBehaviour {

    public float Speed;
	// Use this for initialization
	void Start () {
        Debug.Log("Player Started");
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
