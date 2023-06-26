using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDestroyer : MonoBehaviour
{
    public GameObject Destroyer;
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
            Destroy(this.gameObject);   
        }
    }

    void Update(){
        Debug.Log(CheckDestroyerCollision.brickOnDestroyer);
    }

    //wenn wir links und rechts noch pfeile ergänzen: diese im asynchon (de)aktivieren
}
