using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
	[SerializeField] private float time = 0.5f;
	[SerializeField] private bool reversed = false;
	private bool open = false;
	private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void OpenDoor()
	{
		if (!open)
		{
			StartCoroutine(Open());
			audioSource.Play();
		}
		open = true;
	}

	IEnumerator Open()
	{
		float elapsedTime = 0f;
		float originAngle = gameObject.transform.localEulerAngles.y;
		float mod = 1;
		if (reversed)
			mod = -1;
		while (elapsedTime < time)
		{
			gameObject.transform.localEulerAngles = new Vector3 (gameObject.transform.localEulerAngles.x, (elapsedTime / time) * 90 * mod + originAngle, gameObject.transform.localEulerAngles.z);
			elapsedTime += Time.deltaTime;
			yield return (null);
		}
	}
}
