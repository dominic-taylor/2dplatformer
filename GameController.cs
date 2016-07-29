using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {

	public int coinCount;
	public Text scoreText; 

	// Use this for initialization
	void Start () {
		coinCount = 0;
	}

	public void AddScore (int newScoreValue)
	{
		coinCount += newScoreValue;
		UpdateScore ();
	}
	// Update is called once per frame
	void UpdateScore () {	
		scoreText.text = "Coins: " + coinCount;
	}
}
