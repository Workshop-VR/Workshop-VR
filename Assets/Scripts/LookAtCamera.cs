using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
	private Transform pivot;
	private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
		pivot = GetComponent<Transform>();
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        pivot.LookAt(cam.transform);
    }
}
