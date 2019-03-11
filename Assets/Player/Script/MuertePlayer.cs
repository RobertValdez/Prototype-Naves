using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuertePlayer : MonoBehaviour {

	void OnTriggerEnter(Collider colider){
		if (colider.name == "Projectile(Clone)") {
			Destroy (this.gameObject);
			PlayerPrefs.GetFloat ("HighScores");	
			GameMaganerPlaying.sharedInstance.SalvarResultados ();
			GameManager.sharedInstance.GameOverState ();
		}
	}
}
