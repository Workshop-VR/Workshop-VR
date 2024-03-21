using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndManager : MonoBehaviour
{
	[SerializeField] private Box[] boxes;

	public bool Check()
	{
		foreach (Box box in boxes)
		{
			if (!box.GetState())
				return (false);
		}
		Debug.Log("GG !");
		return (true);
	}

    // Start is called before the first frame update
    void Start()
    {
        foreach (var box in boxes)
		{
			box.SetEndManager(this);
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
