using UnityEngine;
using System.Collections;

public class RackAreaController : MonoBehaviour {

	public GameObject rack;

	public Dimension dimension;

	private int row;
	private int column;

	private Object[] racks = new Object[100];

	public void SetRow(float value) {
		row = (int)value;
		SetCapacity ();
	}

	public void SetColumn(float value) {
		column = (int)value;
		SetCapacity ();
	}

	void SetCapacity() {
		for(int i = 0;i < 100;i++) {
			Destroy (racks [i]);
		}

		Vector3 position = transform.position;
		Quaternion rotation = transform.rotation;
		GameObject obj;

		for (int i = 0; i < row; i++) {
			for (int j = 0; j < column; j++) {
				obj = Instantiate (rack, new Vector3 (
					position.x + j * dimension.width,
					dimension.height,
					position.z + i * dimension.depth
				), rotation) as GameObject;

				racks[i * column + j] = obj;
				obj.transform.parent = transform;
			}
		}
	}

	// Use this for initialization
	void Start () {
		SetCapacity ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
