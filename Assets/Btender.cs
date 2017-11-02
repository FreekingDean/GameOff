using UnityEngine;
using System.Collections;

public class Btender : MonoBehaviour {
	private const int MAX_TAPS = 3;
	private int tapMarker;
	public GameObject beerGlass;
	private SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		beerGlass.GetComponent<Animator> ().StopPlayback ();
		tapMarker = 0;
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
			tapMarker = MAX_TAPS;
		}
		if (tapMarker > MAX_TAPS) {
			tapMarker = 0;
		}
		transform.position = new Vector2 (transform.position.x, tapMarker);

		if (Input.GetKeyDown (KeyCode.Space)) {
			fillBeer ();
		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			stopFill ();
		}
		beerGlass.transform.position = new Vector2 (transform.position.x, tapMarker);
	}

	void fillBeer() {
		beerGlass.GetComponent<Animator> ().StartPlayback ();
	}

	void stopFill() {
		beerGlass.GetComponent<Animator> ().StopPlayback ();
	}
}
