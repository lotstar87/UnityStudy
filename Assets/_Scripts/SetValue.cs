using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetValue : MonoBehaviour {
	
	public void SetIntValue(float value) {
		gameObject.GetComponent<Text>().text = ((int)value).ToString ();
	}
}
