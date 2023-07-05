using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Teil von Pauls Feature
public class CheckDestroyerCollision : MonoBehaviour
{
    public static bool brickOnDestroyer = false;
    public Material normalDestroyerMaterial;
    public Material hoverDestroyerMaterial;

    void OnTriggerEnter(Collider other)
    {
        brickOnDestroyer = true;

        gameObject.GetComponent<MeshRenderer>().material=hoverDestroyerMaterial;

    }

    void OnTriggerExit(Collider other)
    {
        brickOnDestroyer = false;
   
        gameObject.GetComponent<MeshRenderer>().material=normalDestroyerMaterial;

    }
}
