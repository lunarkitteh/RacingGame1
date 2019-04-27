using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveByTouch : MonoBehaviour {
	private float screenCenterX;
	private void Start()
	{
		// save the horizontal center of the screen
		screenCenterX = Screen.width * 0.5f;
	}
	// Update is called once per frame
	void Update () {
		transform.position += transform.forward * Time.deltaTime * 10f;
		// if there are any touches currently
		if (Input.touchCount > 0) {
			// get the first one
			Touch firstTouch = Input.GetTouch (0);
				if (firstTouch.position.x > screenCenterX) {
					transform.Rotate (Vector3.up * Time.deltaTime, 3f, Space.World);
				} else if (firstTouch.position.x < screenCenterX) {
					transform.Rotate (Vector3.up * Time.deltaTime, -3f, Space.World);
				}
			}
		}
	}
