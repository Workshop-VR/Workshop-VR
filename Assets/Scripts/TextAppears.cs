using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextAppears : MonoBehaviour
{
	private TextMeshPro indice;                         

	void Start()
	{
        indice = GameObject.Find("IndiceText").GetComponent<TextMeshPro>();
		indice.color = new Color32(200, 140, 50, 0);                                       // Set la couleur du texte et de l'alpha a 0 (non visible de base)
	}


	void Update()
	{

	}

    private void OnTriggerEnter(Collider light)
    {
		if (light.gameObject.layer == 3)                                                    // Check si l'object est rentré dans une zone de chaleur pour faire apparaitre le texte
		{
			indice.color = new Color32(200, 140, 50, 255);                                  // Change l'alpha a 1
		}
        
    }

    private void OnTriggerExit(Collider light)
    {
        if (light.gameObject.layer == 3)
        {
            indice.color = new Color(0, 0, 0, 0);                                           // Remet l'alpha a 0 quand l'objet quitte le collider 
        }


    }
}
