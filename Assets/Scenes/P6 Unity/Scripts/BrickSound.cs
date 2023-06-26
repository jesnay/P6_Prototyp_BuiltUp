using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Teil von Pauls Feature
public class BrickSound : MonoBehaviour
{

    public AudioSource placeBrickSound;
    public AudioSource deleteBrickSound;
    public void PlayBrickSound(){
        if(CheckDestroyerCollision.brickOnDestroyer){
            deleteBrickSound.Play();   
        } else{
                placeBrickSound.Play();   
        }
    }
}
