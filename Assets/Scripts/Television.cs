using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Television : MonoBehaviour
{

	[SerializeField] private GameObject screen;

	bool activated = false;

	public void OnSelected()
	{
		activated = !activated;
		screen.SetActive(activated);
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
