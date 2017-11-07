using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeerController : MonoBehaviour {
	public bool flyLeft;
	public bool shouldMove;
	public float speed;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (shouldMove) {
			float toAdd = speed;
			if (flyLeft) {
				toAdd = speed * -1;
			}
			transform.position = new Vector2 (transform.position.x + toAdd, transform.position.y);
		}
	}
}
