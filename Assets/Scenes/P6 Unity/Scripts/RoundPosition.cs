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
    {        Debug.Log(transform.position+"Pos before");

        int afterDecimalPoint = 1; //how many decimal places there should be 

        // Example:
        // Mathf.Round(0.0536*Mathf.Pow(10,2)))/Mathf.Pow(10, 2))
        // Output: 0.05

        float xPos = (Mathf.Round(transform.position.x * Mathf.Pow(10, afterDecimalPoint)) / Mathf.Pow(10, afterDecimalPoint));
        float yPos = (Mathf.Round(transform.position.y * Mathf.Pow(10, afterDecimalPoint)) / Mathf.Pow(10, afterDecimalPoint));
        float zPos = (Mathf.Round(transform.position.z * Mathf.Pow(10, afterDecimalPoint)) / Mathf.Pow(10, afterDecimalPoint));

        transform.position = new Vector3(xPos, yPos, zPos);
        Debug.Log(transform.position+"Pos after");
    }
}