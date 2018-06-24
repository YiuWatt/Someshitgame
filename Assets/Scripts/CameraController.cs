using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate ()                // no idea why I called LateUpdate instead of Update. I just saw a tutorial in Youtube. 
	{
		transform.position = player.transform.position + offset; 
	}
}
// no u! AHAHAHAHAHA 