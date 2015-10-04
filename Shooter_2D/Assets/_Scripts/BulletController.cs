using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

    public float Speed;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().velocity = transform.forward * Speed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
