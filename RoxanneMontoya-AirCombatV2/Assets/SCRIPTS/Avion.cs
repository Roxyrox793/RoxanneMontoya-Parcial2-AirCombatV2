using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (0f, 0f, 0.5f);
		if (Input.GetKey (KeyCode.UpArrow)) {
			this.transform.Translate (0.0f, 0.5f, 0.0f);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.transform.Translate (-0.5f, 0.0f, 0.0f);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			this.transform.Translate (0.5f, 0f, 0.0f);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			this.transform.Translate (0.0f, -0.5f, 0.0f);

		}
		if(Input.GetKeyDown(KeyCode.Space)) {
			GameObject Misil = GameObject.Instantiate(
				Resources.Load("Prefabs/Misil") as GameObject);
			
			Misil.transform.SetParent (this.gameObject.transform);

			Misil.transform.localPosition = new Vector3 (0.489f, -1.283f, 0.678f);

			Misil.transform.SetParent (null);
		

		}
		
	}
}
