using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	private const int MAX_TAPS = 3;
	private int tapMarker;
	public int playerNum;
	public GameObject beerPre;

	// Use this for initialization
	void Start () {
		tapMarker = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			tapMarker += 1;
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			tapMarker -= 1;
		}

		if (tapMarker < 0) {
			tapMarker = MAX_TAPS-1;
		}
		if (tapMarker >= MAX_TAPS) {
			tapMarker = 0;
		}
		transform.position = new Vector2 (transform.position.x, (tapMarker*5)-5);
		if (Input.GetKeyDown (KeyCode.Space)) {
			serveBeer ();
		}
	}

	void serveBeer() {
		GameObject beer;
		int toAdd = 1;
		if (flyLeft) {
			toAdd = -1;
		}
		beer = (GameObject)Instantiate (beerPre, new Vector2 (transform.position.x + toAdd, transform.position.y), transform.rotation);
		BeerController controller;
		controller = beer.GetComponent<BeerController> ();
		controller.flyLeft = flyLeft;
		controller.shouldMove = true;
	}
}
