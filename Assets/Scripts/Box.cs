using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
	[SerializeField] private Transform pivot;
	[SerializeField] private float time = 0.5f;
	[SerializeField] private string objectTag;

	private float defaultAngle = -70;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == objectTag)
		{
			StartCoroutine(CloseBox());
		}	
	}

	// Start is called before the first frame update
	void Start()
    {
		
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	IEnumerator CloseBox()
	{
		float elapsedTime = 0;
		while (elapsedTime < time)
		{
			pivot.localEulerAngles = new Vector3(defaultAngle - (elapsedTime / time) * defaultAngle, 0, 0);
			elapsedTime += Time.deltaTime;
			yield return null;
		}
	}
}
