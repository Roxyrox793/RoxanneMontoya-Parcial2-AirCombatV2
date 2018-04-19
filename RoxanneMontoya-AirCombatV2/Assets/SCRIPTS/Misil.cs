using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misil : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}



	void OnCollisionEnter(Collision collision){


		if(collision.collider.gameObject.tag == "MarsAlien") {
			GameObject marsexplosion = GameObject.Instantiate (Resources.Load ("Prefabs/MarsExplosion")as GameObject);
			marsexplosion.transform.position = collision.collider.gameObject.transform.position; 
			Destroy (collision.collider.gameObject);

			Destroy (this.gameObject);
		}

		if(collision.collider.gameObject.tag == "JupiterAlien") {
			GameObject jupiterexplosion = GameObject.Instantiate (Resources.Load ("Prefabs/JupiterExplosion")as GameObject);
			jupiterexplosion.transform.position = collision.collider.gameObject.transform.position; 

			Destroy (collision.collider.gameObject);

			Destroy (this.gameObject);
		}

	}
	// Update is called once per frame
	void Update () {
		this.transform.Translate (0, 0, 2);

	}
}

