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
    private float otherXPos;
    private float otherXScale;
    private float otherZPos;
    private float otherZScale;
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
            /*otherXPos=other.gameObject.transform.position.x;
            otherXScale=other.gameObject.transform.localScale.x;
            otherZPos=other.gameObject.transform.position.z;
            otherZScale=other.gameObject.transform.localScale.z;*/

        }
    }

    private void OnTriggerExit(Collider other){
         insideBlock=false;
         Debug.Log(insideBlock);
    }

    public void moveUp(){
        float centerYPos=otherYPos+(otherYScale/2);
        float centerXPos=otherXPos+(otherXScale/2);
        float centerZPos=otherZPos+(otherZScale/2);
        
        if(insideBlock==true){
            if(transform.position.y>centerYPos){
                transform.position = new Vector3(transform.position.x, otherYPos + 0.028f, transform.position.z);
            }else if(transform.position.y<centerYPos){
                transform.position = new Vector3(transform.position.x, otherYPos - 0.028f, transform.position.z);
            }/*

           if(transform.position.x>centerXPos){
                transform.position = new Vector3(otherXPos + 0.028f, transform.position.y, transform.position.z);
            }else if(transform.position.x<centerXPos){
                transform.position = new Vector3(otherXPos - 0.028f, transform.position.y, transform.position.z);
            }

            if(transform.position.z>centerZPos){
                transform.position = new Vector3(transform.position.x, transform.position.y, otherZPos + 0.028f);
            }else if(transform.position.z<centerZPos){
                transform.position = new Vector3(transform.position.x, transform.position.y, otherZPos - 0.028f);
            }*/
            lastSet=false;
            insideBlock=false;
        }
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
