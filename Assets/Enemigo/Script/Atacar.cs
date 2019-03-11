using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atacar : MonoBehaviour {

	public GameObject projectile;

	void Start(){

		float rb = Random.Range (1f, 2f);
		InvokeRepeating ("Fire", rb, rb);
	}

	void Fire () {
		if (GameManager.sharedInstance.currentGameState == GameState.inPlay) {
			GameObject clone;
			clone = Instantiate (projectile, this.transform.position, this.transform.rotation) as GameObject;
			clone.GetComponent<Rigidbody> ().AddForce (Vector3.down * 10);
			Destroy (clone, 1.5f);
		}
	}
}