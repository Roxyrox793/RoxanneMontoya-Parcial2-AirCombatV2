using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misil : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void OnCollisionEnter(Collision collision){
		Destroy (collision.collider.gameObject);
		Destroy (this.gameObject);

	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (0f, 0f, 0.7f);  
		
	}
}
