using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Transformation;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.State;

public class AddNewBrick : MonoBehaviour
{
    private bool wasSelectedFirstTime = false; // Prevents code from being retrieved more than once 
    public bool isPlaced = false; //checks wheater it is used as building block (true) or as hotbar block (false)
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

    public void ScaleCurrentObject()
    {
        float objectSize = 1f; // size which should be while building
        transform.localScale = new Vector3(objectSize, objectSize, objectSize);
        // Debug.Log("Scale" + transform.localScale + "Name = " + gameObject.name);
    }

    public void AddBuildingBrick()
    {
        //Debug.Log("This scale: " + transform.position.ToString("f5") + "Name = "+ gameObject.name, this);

        if (wasSelectedFirstTime == false)
        {

            GameObject obj = Instantiate(gameObject, gameObjectDefaultPosition, transform.rotation); // spawn new gameObject
            obj.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f); // size in inventar


            objectCollider.isTrigger = true;
            wasSelectedFirstTime = true;

            // Disable components. Should only enabled at the beginning/ first selection
            gameObject.GetComponent<UniformTransformScaleAffordanceReceiver>().enabled = false;
            gameObject.GetComponent<XRInteractableAffordanceStateProvider>().enabled = false;

            isPlaced = true; // importante for ResetScene.cs

        }


    }

}
