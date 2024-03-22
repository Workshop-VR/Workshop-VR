using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndManager : MonoBehaviour
{
	[SerializeField] private Box[] boxes;
	[SerializeField] private string sceneToLoad;

	public bool Check()
	{
		foreach (Box box in boxes)
		{
			if (!box.GetState())
				return (false);
		}
		Validate();
		return (true);
	}

	private void Validate()
	{
		Debug.Log("GG !");
		SceneManager.LoadScene(sceneToLoad);
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
