﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamFollow : MonoBehaviour {

	//public float optimalDistance
	public Transform lookPos;
	CinemachineBrain brain;
	Rover r;

	void Update() {
		SetLookPos ();
	}

	public void SetNewLevel(Transform start, Rover rover) {
		r = rover;
		SetLookPos ();

		brain = GetComponent<CinemachineBrain> ();
		brain.ActiveVirtualCamera.LookAt = lookPos;
		brain.ActiveVirtualCamera.Follow = rover.transform;

	}

	void SetLookPos() {
		if (r != null) {
			lookPos.position = r.transform.position;
		}
	}
}
