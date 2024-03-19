using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketDetector : MonoBehaviour
{
	[SerializeField] private BasketGoal bg;
	private bool hasEntered = false;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Basketball")
		{
			hasEntered = true;
			bg.Check();
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Basketball")
		{
			hasEntered = false;
		}
	}

	public bool GetHasEntered()
	{
		return (hasEntered);
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
