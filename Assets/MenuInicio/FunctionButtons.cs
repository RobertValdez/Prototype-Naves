using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class FunctionButtons : MonoBehaviour {

	public void OnClicPlay(){
		GameManager.sharedInstance.GamePlayState ();
	}
	public void OnClicHighScores(){
		GameManager.sharedInstance.canvasMenuGame.enabled = false;
		GameManager.sharedInstance.canvasHighScores.enabled = true;
		GameMaganerPlaying.sharedInstance.Start ();
	}
	public void OnClicSalir(){
		Application.Quit ();
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#endif
	}

	public void OnClicReiniciarNivel(){
		GameManager.sharedInstance.GamePlayState ();
	}
	public void OnClicMenuPrincipal(){
		GameManager.sharedInstance.MenuGameState ();
	}
	public void OnClicResetValues(){
	//	GUI.Box(Rect(0,0,Screen.width/2,Screen.height/2),"This is the text to be displayed");
		PlayerPrefs.DeleteKey("HighScores");
		GameMaganerPlaying.sharedInstance.Start ();
	}
	public void OnClicBack(){
		GameManager.sharedInstance.canvasMenuGame.enabled = true;
		GameManager.sharedInstance.canvasHighScores.enabled = false;
	}
}