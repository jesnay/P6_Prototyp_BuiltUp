using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDestroyer : MonoBehaviour
{
    public GameObject Destroyer;
    public GameObject Cube1;
    public GameObject Cube2;
    public Material normalDestroyerMaterial;
    public void activateDestroyMode()
    {
        Destroyer.SetActive(true);
    }
    public void deactivateDestroyMode()
    {
        Destroyer.SetActive(false);
    }

    public void checkDestruction(){
        if(CheckDestroyerCollision.brickOnDestroyer){
            CheckDestroyerCollision.brickOnDestroyer = false;
            Cube1.GetComponent<MeshRenderer> ().material = normalDestroyerMaterial;
            Cube2.GetComponent<MeshRenderer> ().material = normalDestroyerMaterial;
            Destroy(this.gameObject);   
        }
    }

    // void Update(){
        // Debug.Log(CheckDestroyerCollision.brickOnDestroyer);
    // }
}
