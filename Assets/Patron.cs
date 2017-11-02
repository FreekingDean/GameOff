using UnityEngine;
using System.Collections;

public class Patron : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector2 (transform.position.x - 1, transform.position.y);
	}
}
