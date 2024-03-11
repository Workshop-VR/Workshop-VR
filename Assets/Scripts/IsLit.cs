using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsLit : MonoBehaviour
{
    public bool isLit;                                              // Booléen, feu allumé ou non
    private Collider heatCollider;                                  // Collider trigger de l'apparition d'indice
    public GameObject lightable;                                    // GameObject qui change de couleur si allumé
    public Material m_light;                                        // Matériau de quand c'est allumé

    void Start()
    {
        heatCollider = GetComponent<Collider>();                    // /!\ doit etre le premie collider du gameobject


        // Check si l'object est allumé au départ
        if (isLit == true)                                              
        {
            heatCollider.enabled = true;
            lightable.GetComponent<Renderer>().material = m_light;
        }
        else 
        {
            heatCollider.enabled = false;
        }


    }


    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.layer == 6)
        {
            isLit = true;
            heatCollider.enabled = true;
            lightable.GetComponent<Renderer>().material = m_light;
            Debug.Log("Allumé");

        }
    }
}
