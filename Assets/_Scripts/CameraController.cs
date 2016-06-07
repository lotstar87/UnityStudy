using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	private  float zoomAmount = 0; //With Positive and negative values\

	public float maxToClamp = 10;
	public float rotSpeed = 1;

	void Update() {

		zoomAmount += Input.GetAxis("Mouse ScrollWheel");
		zoomAmount = Mathf.Clamp(zoomAmount, -maxToClamp, maxToClamp);
		var translate = Mathf.Min(Mathf.Abs(Input.GetAxis("Mouse ScrollWheel")), maxToClamp - Mathf.Abs(zoomAmount));
		gameObject.transform.Translate(0,0,translate * rotSpeed * Mathf.Sign(Input.GetAxis("Mouse ScrollWheel")));
	}
}

