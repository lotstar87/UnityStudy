using UnityEngine;
using System.Collections;

public class PanelRotator : MonoBehaviour {

	public Transform settingPanel;
	public Transform palletPanel;

	private float rotation;

	public void SetRotation(float value) {
		rotation = (int)value;

		Quaternion rotateSettingPanel = settingPanel.rotation;
		Quaternion rotatePalletPanel = palletPanel.rotation;

		settingPanel.rotation = Quaternion.Euler(
			rotateSettingPanel.x,
			rotation,
			rotateSettingPanel.z
		);

		palletPanel.rotation = Quaternion.Euler(
			rotatePalletPanel.x,
			-rotation,
			rotatePalletPanel.z
		);
	}
}
