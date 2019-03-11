using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour {

	public GameObject proyectil;
	public float speed = 10f;

	void Update ()
	{
		if (GameManager.sharedInstance.currentGameState == GameState.inPlay) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				GameObject clone;
				clone = Instantiate (proyectil, this.transform.position, this.transform.rotation) as GameObject;
				clone.GetComponent<Rigidbody> ().AddForce (Vector3.up * 800, ForceMode.Acceleration);
				Destroy (clone, 1f);
			}
		}
	}
}
