using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
	Material mat;

    // Start is called before the first frame update
    void Start()
    {
		mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void OnClick()
	{
		Debug.Log("Clic !");
		StartCoroutine(ChangeColor());
	}

	public void OnSelected()
	{
		mat.color = Color.yellow;
	}

	public void OnDeselected()
	{
		mat.color = Color.red;
	}

	IEnumerator ChangeColor()
	{
		mat.color = Color.yellow;
		yield return new WaitForSeconds(0.1f);
		mat.color = Color.red;
	}
}
