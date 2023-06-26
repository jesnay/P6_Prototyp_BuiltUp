using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleDestroyer : MonoBehaviour
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
            Destroy(this.gameObject);        
        }

    }

    //wenn wir links und rechts noch pfeile ergänzen: diese im asynchon (de)aktivieren
}
