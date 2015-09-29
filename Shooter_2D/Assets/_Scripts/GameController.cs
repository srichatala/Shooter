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
