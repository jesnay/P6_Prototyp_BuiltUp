using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Hier beginnt Jennifers Feature
// Dieses Script ist dafür zuständig, dass gesetzte Bausteine erkennen, ob sie in einem anderen Baustein plaziert wurden 
// und dann je nach Position entweder über den Baustein oder unter den Baustein springen.
// Dabei wird zwischen den verschiedenen Bausteinarten per Tag differenziert.
public class CheckCollision : MonoBehaviour
{
    private bool isTriggered;
    private bool lastSet=false;
    private bool insideBlock=false;

    private float otherYPos;
    private float otherYScale;
    private string triggerTag;

    // Checks if this brick is the last, that was grabbed
    public void checkSelected(){
        lastSet=true;
    }

    // Sets the variable to true if the brick was triggered.
    // Gets data from the touched brick
    private void OnTriggerEnter(Collider other){
        if(lastSet==true){
            insideBlock=true;
            Debug.Log("Trigger enter");
            otherYPos=other.gameObject.transform.position.y;
            otherYScale=other.gameObject.transform.localScale.y;
            triggerTag = other.gameObject.tag;
        }
    }

    // Sets variable back to false when the brick is not triggered anymore
    private void OnTriggerExit(Collider other){
         insideBlock=false;
         Debug.Log("Trigger exit");
    }

    // If the brick is let go the function will move the brick to its right position. 
    // This depends on its current position, the position of the triggered brick and their types.
    // In the end all variables are set back.
    public void moveUp(){
        float centerYPos=otherYPos+(otherYScale/2);
        Debug.Log(insideBlock);

        if(insideBlock==true){
            if(transform.position.y>centerYPos){
                if(triggerTag == "flat"){
                    transform.position = new Vector3(transform.position.x, otherYPos + 0.0096f, transform.position.z);
                } else if(triggerTag == "high 2x"){
                    transform.position = new Vector3(transform.position.x, otherYPos + 0.058f, transform.position.z);
                } else if(triggerTag == "high 4x"){
                    transform.position = new Vector3(transform.position.x, otherYPos + 0.116f, transform.position.z);
                } else if(triggerTag == "flag"){
                    transform.position = new Vector3(transform.position.x, otherYPos + 0.232f, transform.position.z);
                } else {
                     transform.position = new Vector3(transform.position.x, otherYPos + 0.029f, transform.position.z);
                }
               
            }else if(transform.position.y<centerYPos){
                if(gameObject.tag == "flat"){
                    transform.position = new Vector3(transform.position.x, otherYPos - 0.0096f, transform.position.z);
                } else if(gameObject.tag == "high 2x"){
                    transform.position = new Vector3(transform.position.x, otherYPos - 0.058f, transform.position.z);
                } else if(gameObject.tag == "high 4x"){
                    transform.position = new Vector3(transform.position.x, otherYPos - 0.116f, transform.position.z);
                } else if(gameObject.tag == "flag"){
                    Debug.Log("flag position down");
                    transform.position = new Vector3(transform.position.x, otherYPos - 0.232f, transform.position.z);
                } else {
                    transform.position = new Vector3(transform.position.x, otherYPos - 0.029f, transform.position.z);
                }
            
            }
            lastSet=false;
            insideBlock=false;
        }
        
    }

    
}
