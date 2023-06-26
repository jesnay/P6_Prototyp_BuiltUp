using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDestroyerCollision : MonoBehaviour
{
    public static bool brickOnDestroyer = false;
    public GameObject Cube1;
    public GameObject Cube2;
    public Material normalDestroyerMaterial;
    public Material hoverDestroyerMaterial;

    void OnTriggerEnter(Collider other)
    {
        brickOnDestroyer = true;
        Cube1.GetComponent<MeshRenderer> ().material = hoverDestroyerMaterial;
        Cube2.GetComponent<MeshRenderer> ().material = hoverDestroyerMaterial;

    }

    void OnTriggerExit(Collider other)
    {
        brickOnDestroyer = false;
        Cube1.GetComponent<MeshRenderer> ().material = normalDestroyerMaterial;
        Cube2.GetComponent<MeshRenderer> ().material = normalDestroyerMaterial;
    }
}
