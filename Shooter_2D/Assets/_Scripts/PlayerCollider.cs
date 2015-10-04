/*
Author: Sri Chatala
File : PlayerCollider.cs
Created Date: Spe 30,2015
Descriptopn: Player Collider script controll if the gameObject collide with other gameObjects
Laster Updated: Spe 25,2015
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerCollider : MonoBehaviour {

    //Private variables
    private AudioSource[] _gameAuidoSource;
    private AudioSource _devilAudioSource,_goldAudioSource;

    public Text livesLabel;
    public Text scoreLabel;
    public int _score = 0;
    public int lives = 5;
    public Text gameOver;
    public Text finalScore;
        
    // Use this for initialization
	void Start () {
        this._gameAuidoSource = this.GetComponents<AudioSource>();
        this._devilAudioSource = this._gameAuidoSource[1];
        this._goldAudioSource = this._gameAuidoSource[2];
        this._SetLives();
        this.gameOver.enabled = false;
        this.finalScore.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D otherGameObject)
    {
        if (otherGameObject.tag == "Gold")
        {
            this._goldAudioSource.Play();
            this._score += 100;
        }
        if (otherGameObject.tag == "Devil")
        {
            this._devilAudioSource.Play();
            this.lives -= 1;
            if (this.lives <= 0)
            {
                this._EndGame();
            }
        }
        
        this._SetLives();
    }
    private void _SetLives()
    {
        this.livesLabel.text = "Lives:" + this.lives;
        this.scoreLabel.text = "Score:" + this._score;
    }
    private void _EndGame()
    {
        Destroy(gameObject);
        this.livesLabel.enabled = false;
        this.scoreLabel.enabled = false;
        this.gameOver.enabled = true;
        this.finalScore.enabled = true;
        this.finalScore.text = "Final Score:"+this._score;
    }
}
