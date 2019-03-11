using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState{
	menu,
	inPlay,
	gameOver
}

public class GameManager : MonoBehaviour {

	public GameState currentGameState = GameState.menu;

	public static GameManager sharedInstance; 
	public List<Vector3> positionEnemy = new List<Vector3>();

	public GameObject prefabEnemy;
	public GameObject prefabPlayer;
	public Canvas canvasGameOver;
	public Canvas canvasMenuGame;
	public Canvas canvasGamePlay;
	public Canvas canvasHighScores;
	void Awake () {
		sharedInstance = this;
	}
	void Start(){
		MenuGameState ();
	}
	void Update(){
		if (!GameObject.FindGameObjectWithTag("Enemigo")) {
			foreach (Vector3 item in positionEnemy) {
				GameObject clone =	Instantiate (prefabEnemy);
				clone.transform.position = item;
			}
		}
		if (!GameObject.FindGameObjectWithTag("Player")) {
			GameOverState ();
		}
	}
	public void MenuGameState(){
		canvasGamePlay.enabled = false;
		canvasGameOver.enabled = false;
		canvasHighScores.enabled = false;

		canvasMenuGame.enabled = true;
		currentGameState = GameState.menu;
		StartGame ();
	}
	public void GamePlayState(){
		canvasMenuGame.enabled = false;
		canvasGameOver.enabled = false;

		canvasGamePlay.enabled = true;
		currentGameState = GameState.inPlay;
		if (!GameObject.FindGameObjectWithTag("Player")) {
			StartGame ();	
		}
	}

	public void GameOverState(){
		canvasMenuGame.enabled = false;
		canvasGamePlay.enabled = false;

		canvasGameOver.enabled = true;
		currentGameState = GameState.gameOver;
	}

	public void StartGame(){
		positionEnemy = new List<Vector3> ();

		if (GameObject.FindGameObjectWithTag("Enemigo")) {
			GameObject[] obj = GameObject.FindGameObjectsWithTag("Enemigo");
			GameObject g = null;
			foreach (object o in obj)
			{	
				g = (GameObject) o;
				Destroy (g);
			}
		}

		GameObject Player =	Instantiate (prefabPlayer);
		Player.transform.position = new Vector3(0f, -2.23f, -2.632f);

		positionEnemy.Add (new Vector3 (-4.5f, 4.5f, -2.6f));
		positionEnemy.Add (new Vector3 (4.2f, 4.6f, -2.6f));
		positionEnemy.Add (new Vector3 (1.3f, 4.7f, -2.6f));
		positionEnemy.Add (new Vector3 (-1.7f, 4.6f, -2.6f));
		positionEnemy.Add (new Vector3 (-6.9f, 4.6f, -2.6f));
		positionEnemy.Add (new Vector3 (6.8f, 4.7f, -2.6f));

		foreach (Vector3 item in positionEnemy) {
			GameObject clone =	Instantiate (prefabEnemy);
			clone.transform.position = item;
		}
	}
}