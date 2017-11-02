#pragma strict

private var tapMarker : int = 0;
private var pressedW : boolean = false;
private var pressedS : boolean = false;

function Start () {

}

function Update () {
	if (Input.GetKeyDown(KeyCode.W) && !pressedW) {
		tapMarker += 1;
		pressedW = true;
	}
	if (Input.GetKeyUp(KeyCode.W)) {
		pressedW = false;
	}
	if (Input.GetKey(KeyCode.S) && ! pressedS) {
		tapMarker -= 1;
		pressedS = true;
	}
	if (Input.GetKeyUp(KeyCode.S)) {
		pressedS = false;
	}
	if(tapMarker < 0) {
		tapMarker = 3;
	}
	if(tapMarker > 3) {
		tapMarker = 0;
	}

	transform.position.y = (tapMarker*1);
}