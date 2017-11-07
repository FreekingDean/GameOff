using UnityEngine;
using System.Collections;

public class Patron : MonoBehaviour {
	private bool drinking;
	private float willStopDrinkingAt;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (drinking) {
			gameObject.GetComponent<Renderer> ().material.color = Color.green;
		} else {
			gameObject.GetComponent<Renderer> ().material.color = Color.white;
		}

		if (Time.time > willStopDrinkingAt) {
			drinking = false;
		}
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (!drinking) {
			transform.position = new Vector2 (coll.gameObject.transform.position.x, transform.position.y);
			drinking = true;
			Destroy (coll.gameObject);
			int drinkingTime = Random.Range (1, 5);
			willStopDrinkingAt = Time.time + ((float)drinkingTime);
		} else {
			BeerController bc = coll.gameObject.GetComponent<BeerController> ();
			bc.flyLeft = !bc.flyLeft;
		}
	}
}
