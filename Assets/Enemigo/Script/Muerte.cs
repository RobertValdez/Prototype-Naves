using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : MonoBehaviour {

	public GameObject prefabEnemy;

	void OnTriggerEnter(Collider colider){
		if (colider.name == "Projectil(Clone)") {
			Destroy(this.gameObject);
			GameMaganerPlaying.sharedInstance.Scores += 5f;
		}
	}
}
