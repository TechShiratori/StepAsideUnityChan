using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour {

	private GameObject mainCamera;

	// Use this for initialization
	void Start () {
		mainCamera = GameObject.Find ("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.z < mainCamera.transform.position.z) {
			Destroy (gameObject);
		}
	}
}
