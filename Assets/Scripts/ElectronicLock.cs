using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class ElectronicLock : MonoBehaviour
{
	[SerializeField] private uint ID;
	[SerializeField] private Door door;
	[SerializeField] private Renderer led;
	[SerializeField] private Material def;
	[SerializeField] private Material red;
	[SerializeField] private Material green;
	[SerializeField] private TextMeshPro idText;
	[SerializeField] private Transform idTransform;
	private bool isActive = false;
	private Camera cam;

	private void OnTriggerEnter(Collider other)
	{
		ElectronicKey key = other.GetComponent<ElectronicKey>();
		if (key != null)
		{
			uint keyID = key.GetKeyID();
			Debug.Log("ID : " + keyID);
			isActive = (ID == keyID);
			led.material = isActive ? green : red;
			if (isActive && door != null)
			{
				door.OpenDoor();
			}
		}
	}

	private void OnTriggerExit(Collider other)
	{
		led.material = def;
	}

	// Start is called before the first frame update
	void Start()
    {
		cam = Camera.main;
		idText.text = "ID #";
		if (ID < 10)
		{
			idText.text += "0";
		}
		idText.text += "" + ID;
	}

    // Update is called once per frame
    void Update()
    {
		idTransform.LookAt(cam.transform, Vector3.up);
	}
}