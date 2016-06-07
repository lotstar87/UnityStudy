using UnityEngine;
using System.Collections;

public class OutboundAreaController : MonoBehaviour {

	public GameObject truck;

	public Dimension dimension;

	private int count;
	private Object[] trucks = new Object[10];

	public void SetTruck(float value) {
		count = (int)value;


		for(int i = 0;i < trucks.GetLength(0);i++) {
			if (trucks [i] != null) {
				Destroy (trucks [i]);
			} else {
				break;
			}
		}
			
		Vector3 position = transform.position;
		Quaternion rotation = transform.rotation;
		GameObject obj;

		for (int i = 0; i < count; i++) {
			obj = Instantiate (truck, new Vector3 (
				position.x - i * dimension.width,
				dimension.height,
				position.z + dimension.depth
			), rotation) as GameObject;

			trucks[i] = obj;
			obj.transform.parent = transform;
		}
	}

	// Use this for initialization
	void Start () {
		SetTruck (0);
	}

}
