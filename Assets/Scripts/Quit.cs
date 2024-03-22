using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
	public void AppQuit()
	{
		Debug.Log("Adieu !");
		Application.Quit();
	}
}
