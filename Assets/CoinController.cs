using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {

	private GameObject mainCamera;

	// Use this for initialization
	void Start () {
		this.transform.Rotate (0, Random.Range (0, 360), 0);
		mainCamera = GameObject.Find ("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate (0, 3, 0);

		if (this.transform.position.z < mainCamera.transform.position.z) {
			Destroy (gameObject);
		}
			
	}
}
