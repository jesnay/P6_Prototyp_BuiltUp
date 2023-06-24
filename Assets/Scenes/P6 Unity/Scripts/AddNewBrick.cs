using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddNewBrick : MonoBehaviour
{
    private bool wasSelectedFirstTime = false;
    private BoxCollider objectCollider;

    private Vector3 gameObjectDefaultPosition;
    // Start is called before the first frame update
    void Start()
    {
        gameObjectDefaultPosition = transform.position;
        objectCollider = gameObject.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddBuildingBrick()
    {
            //Debug.Log("This scale: " + transform.position.ToString("f5") + "Name = "+ gameObject.name, this);

        if (wasSelectedFirstTime == false)
        {

            //GameObject obi = Instantiate(gameObject, gameObjectDefaultPosition, transform.rotation);
            //obi.transform.localScale=new Vector3(0.001f, 0.001f, 0.001f);
            ////objectCollider.isTrigger=true;
            //this.transform.localScale = new Vector3(0.003f, 0.003f, 0.003f);
            Instantiate(gameObject, gameObjectDefaultPosition, transform.rotation);
            //GetComponent<Animator>().enabled = false;
            objectCollider.isTrigger=true;
            wasSelectedFirstTime = true;


        }


    }


    /* public void checkGrab(){
         objectCollider.isTrigger=false;
     }

     public void removeGrab(){
         objectCollider.isTrigger=true;
     }*/
}
