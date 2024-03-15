using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ElectronicLock : MonoBehaviour
{
	[SerializeField] private int ID;
	[SerializeField] private Renderer led;
	[SerializeField] private Material def;
	[SerializeField] private Material red;
	[SerializeField] private Material green;
	private bool isActive = false;

	private void OnTriggerEnter(Collider other)
	{
		ElectronicKey key = other.GetComponent<ElectronicKey>();
		if (key != null)
		{
			int keyID = key.GetKeyID();
			Debug.Log("ID : " + keyID);
			isActive = (ID == keyID);
			led.material = isActive ? green : red;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		led.material = def;
	}

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
