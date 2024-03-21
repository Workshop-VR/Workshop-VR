using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicLightSource : MonoBehaviour
{
	[SerializeField] private GameObject lightSource;



	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.layer == 6)
		{
			lightSource.SetActive(true);
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
}
