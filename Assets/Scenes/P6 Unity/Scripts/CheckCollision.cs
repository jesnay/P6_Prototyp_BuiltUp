using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    private bool isTriggered;
    // Start is called before the first frame update
    private bool lastSet=false;
    private bool insideBlock=false;

    private float otherYPos;
    private float otherYScale;
    private string triggerTag;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkSelected(){
        lastSet=true;
    }


    private void OnTriggerEnter(Collider other){
        if(lastSet==true){
            
            insideBlock=true;
            Debug.Log(insideBlock);
            otherYPos=other.gameObject.transform.position.y;
            otherYScale=other.gameObject.transform.localScale.y;
            triggerTag = other.gameObject.tag;
        }
    }

    private void OnTriggerExit(Collider other){
         insideBlock=false;
         Debug.Log(insideBlock);
    }

    public void moveUp(){
        float centerYPos=otherYPos+(otherYScale/2);
        
        if(transform.position.y>centerYPos){
                if(triggerTag == "flat"){
                    transform.position = new Vector3(transform.position.x, otherYPos + 0.0096f, transform.position.z);
                } else if(triggerTag == "high 2x"){
                    transform.position = new Vector3(transform.position.x, otherYPos + 0.058f, transform.position.z);
                } else if(triggerTag == "high 4x"){
                    transform.position = new Vector3(transform.position.x, otherYPos + 0.116f, transform.position.z);
                } else {
                     transform.position = new Vector3(transform.position.x, otherYPos + 0.028f, transform.position.z);
                }
               
        }else if(transform.position.y<centerYPos){
                if(gameObject.tag == "flat"){
                    transform.position = new Vector3(transform.position.x, otherYPos - 0.0096f, transform.position.z);
                } else if(gameObject.tag == "high 2x"){
                    transform.position = new Vector3(transform.position.x, otherYPos - 0.058f, transform.position.z);
                } else if(gameObject.tag == "high 4x"){
                    transform.position = new Vector3(transform.position.x, otherYPos - 0.116f, transform.position.z);
                } else {
                transform.position = new Vector3(transform.position.x, otherYPos - 0.028f, transform.position.z);
            }
            
        }
            lastSet=false;
            insideBlock=false;
    }

    // public void EnableCollision()
    // {

    //     isTriggered = true;
    //     gameObject.GetComponent<BoxCollider>().isTrigger = true;

    //     gameObject.GetComponent<BoxCollider>().isTrigger = false;
    // }

    // public void OnTriggerEnter(Collider other)
    // {
    //     // if (isTriggered)
    //     // {
    //     gameObject.GetComponent<BoxCollider>().isTrigger = true;

    //     transform.position = new Vector3(transform.position.x, transform.position.y + 0.0192f, transform.position.z);

    //     gameObject.GetComponent<BoxCollider>().isTrigger = false;


    //     // }
    // }
}
