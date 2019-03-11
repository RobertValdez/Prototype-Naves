using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaganerPlaying : MonoBehaviour {
	public static GameMaganerPlaying sharedInstance;

	public Text txtScores;
	public Text txtMonedas;
	public Text txtVidaPlayer;

	public Text txtHighScores;

	public Text txtHighScoresMenu;

	public float Scores = 0;
	public float Monedas = 0;
	public float VidaPlayer = 0;

	void Awake () {
		sharedInstance = this;
	}

	public void Start(){
		txtHighScoresMenu.text = PlayerPrefs.GetFloat ("HighScores").ToString();
	}
	void Update(){
		txtScores.text = Scores.ToString ();

		if (Input.GetKeyDown(KeyCode.Escape) && GameManager.sharedInstance.currentGameState == GameState.inPlay) {
			if (Time.timeScale == 1) {
				Time.timeScale = 0;
			} else {
				Time.timeScale = 1;
			}
		}
	}
	public void SalvarResultados(){
		if (Scores > PlayerPrefs.GetFloat("HighScores")) {
			PlayerPrefs.SetFloat ("HighScores", Scores);	
		}
		txtHighScores.text = PlayerPrefs.GetFloat ("HighScores").ToString();	
		Scores = 0;
	}
}
