using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddNewBrick : MonoBehaviour
{
    private bool wasSelectedFirstTime = false;

    private Vector3 gameObjectDefaultPosition;
    // Start is called before the first frame update
    void Start()
    {
        gameObjectDefaultPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddBuildingBrick()
    {
        if (wasSelectedFirstTime == false)
        {

            Instantiate(gameObject, gameObjectDefaultPosition, transform.rotation);
            wasSelectedFirstTime = true;
        }
    }
}
