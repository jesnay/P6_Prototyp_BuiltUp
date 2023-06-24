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
        // Debug.Log(transform.position + "Pos before");

        // int afterDecimalPoint = 1; //how many decimal places there should be 

        // Example:
        // Mathf.Round(0.0536*Mathf.Pow(10,2)))/Mathf.Pow(10, 2))
        // Output: 0.05

        // float xPos = (Mathf.Round(transform.position.x * Mathf.Pow(10, afterDecimalPoint)) / Mathf.Pow(10, afterDecimalPoint));
        // float yPos = (Mathf.Round(transform.position.y * Mathf.Pow(10, afterDecimalPoint)) / Mathf.Pow(10, afterDecimalPoint));
        // float zPos = (Mathf.Round(transform.position.z * Mathf.Pow(10, afterDecimalPoint)) / Mathf.Pow(10, afterDecimalPoint));

        float xSpacing = 0.024f;
        float ySpacing = 0.029f;
        float zSpacing = xSpacing;


        float xPos = (Mathf.Round(transform.position.x / xSpacing) * xSpacing);
        float yPos = (Mathf.Round(transform.position.y / ySpacing) * ySpacing);
        float zPos = (Mathf.Round(transform.position.z / zSpacing) * zSpacing);



        transform.position = new Vector3(xPos, yPos, zPos);
        // Debug.Log(transform.position + "Pos after");
    }
}