using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BasketGoal : MonoBehaviour
{
	[SerializeField] private BasketDetector bd1;
	[SerializeField] private BasketDetector bd2;
	[SerializeField] private TextMeshPro pointText;
	[SerializeField] private AudioClip audioPoint;
	[SerializeField] private AudioClip audioSuperPoint;

	private AudioSource audioSource;
	private int points = 0;
	private bool hasEntered1 = false;
	
	public void Check()
	{
		if (hasEntered1 && bd2.GetHasEntered())
		{
			//Debug.Log("Point !");
			hasEntered1 = false;
			points++;
			audioSource.clip = points % 10 == 0 ? audioSuperPoint : audioPoint;
			audioSource.Play();
			pointText.text = "" + points;
		}
		if (bd1.GetHasEntered() && !bd2.GetHasEntered())
		{
			hasEntered1 = true;
		}
	}

	// Start is called before the first frame update
	void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
