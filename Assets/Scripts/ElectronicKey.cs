using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ElectronicKey : MonoBehaviour
{
	[SerializeField] private uint ID;
	[SerializeField] private TextMeshPro textA;
	[SerializeField] private TextMeshPro textB;

	public uint GetKeyID()
	{
		return (ID);
	}

	// Start is called before the first frame update
	void Start()
    {
		textA.text = "ID #";
		textB.text = "ID #";
		if (ID < 10)
		{
			textA.text += "0";
			textB.text += "0";
		}
		textA.text += "" + ID;
		textB.text += "" + ID;
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
