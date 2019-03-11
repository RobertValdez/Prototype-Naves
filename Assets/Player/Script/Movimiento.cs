using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movimiento : MonoBehaviour {

	Rigidbody rb;
	public float Velocidad = 8f;
	void Start () {
		rb = GetComponent <Rigidbody>();
	}

	void Update () {
		if (GameManager.sharedInstance.canvasGamePlay.enabled == true) {
			rb.velocity = Velocidad * (Input.GetAxis ("Horizontal") * Vector3.right);
		}
	}
}
