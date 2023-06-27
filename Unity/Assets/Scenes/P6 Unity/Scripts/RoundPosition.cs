using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundPosition : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {

    }

    public void RoundPos()
    {
         float xSpacing = 0.024f;
        //float ySpacing = 0.029f;
        float ySpacing = 0.0096f;
        float zSpacing = xSpacing;


        float xPos = (Mathf.Round(transform.position.x / xSpacing) * xSpacing);
        float yPos = (Mathf.Round(transform.position.y / ySpacing) * ySpacing);
        float zPos = (Mathf.Round(transform.position.z / zSpacing) * zSpacing);

        transform.position = new Vector3(xPos, yPos, zPos);
    }
}