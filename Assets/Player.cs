using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ePlayer {
	Left,
	Right
}

public class Player : MonoBehaviour {

	// units the player moves per second
	public float speed = 15f;
	public ePlayer player;

	// check if player pressed a key to decide to move the player
	void FixedUpdate () {
		float inputSpeed = 0f;
		if (player == ePlayer.Left) {
			inputSpeed = Input.GetAxisRaw ("PlayerLeft");
		} else if (player == ePlayer.Right) {
			inputSpeed = Input.GetAxisRaw ("PlayerRight");
		}
		transform.position += new Vector3 (0f, 0f, inputSpeed * speed * Time.deltaTime);

	}
}
