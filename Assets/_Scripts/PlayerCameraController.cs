using UnityEngine;
using System.Collections;

public class PlayerCameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	private  float zoomAmount = 0; //With Positive and negative values\

	public float maxToClamp = 10;
	public float rotSpeed = 1;

		// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}

	void Update() {

		zoomAmount += Input.GetAxis("Mouse ScrollWheel");
		zoomAmount = Mathf.Clamp(zoomAmount, -maxToClamp, maxToClamp);
		var translate = Mathf.Min(Mathf.Abs(Input.GetAxis("Mouse ScrollWheel")), maxToClamp - Mathf.Abs(zoomAmount));
		gameObject.transform.Translate(0,0,translate * rotSpeed * Mathf.Sign(Input.GetAxis("Mouse ScrollWheel")));
	}

	// Update is called once per frame
	void LateUpdate () {
//		transform.position = player.transform.position + offset;
	}
}
