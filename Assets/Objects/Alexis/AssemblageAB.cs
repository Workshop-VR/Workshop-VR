using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alexis : MonoBehaviour
{
    public GameObject B;
    public GameObject BPre;
    public GameObject AB;
    public Transform BTransform;
    public Transform BPreTransform;
    private Renderer rendererB;
    private Renderer rendererBpre;
    private Vector3 positionB;
    private Quaternion rotationB;
    private Vector3 positionBpre;
    private Quaternion rotationBpre;
    private Vector3 positionA;
    private Quaternion rotationA;
    private bool Assemblable;
    private Collider colliderB;

    void Start()
    {
        colliderB = B.GetComponent<Collider>();
        positionB = BTransform.position;
        rotationB = BTransform.rotation;
        rendererB = B.GetComponent<Renderer>();
        positionBpre = BPreTransform.position;
        rotationBpre = BPreTransform.rotation;
        rendererBpre = BPre.GetComponent<Renderer>();
        positionA = transform.position;
        rotationA = transform.rotation;
        Assemblable = false;
}
    void Update()
    {
        //A
        Vector3 positionB = transform.position;
        Quaternion rotationB = transform.rotation;


        float distance = Vector3.Distance(positionA + new Vector3 (-1,0,0), positionB);
        if (distance > 2)
        {
            rendererBpre.enabled = false;
            rendererB.enabled = true;
            colliderB.enabled = true;
        }
        
        if (distance <= 2)
        {
            rendererBpre.enabled = true;
            rendererB.enabled = false;
            MiseEnPosition(positionA, positionBpre, rotationA, rotationBpre);
            Assemblable = true;
            colliderB.enabled = false;
        }

        if (Assemblable == true && Input.GetMouseButtonDown(0))
        {
            GameObject instantiatedObject = Instantiate(AB, positionA, rotationA);
            Destroy(B);
            Destroy(BPre);
            Destroy(gameObject);
        }

    }

    void MiseEnPosition(Vector3 positionA, Vector3 positionBpre, Quaternion rotationA, Quaternion rotationBpre)
    {
        positionBpre = positionA + new Vector3(-1, 0, 0);
        rotationBpre = rotationA;
    }


}
