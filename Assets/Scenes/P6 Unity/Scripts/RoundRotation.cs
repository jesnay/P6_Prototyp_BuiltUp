using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RoundRot()
    {
        // Debug.Log(transform.eulerAngles + "Rotation Before");

        Vector3 newRotation = transform.eulerAngles;

        newRotation.x = 0; // ((Mathf.Round(newRotation.x / 90)) * 90);
        newRotation.y = ((Mathf.Round(newRotation.y / 90)) * 90);
        newRotation.z = 0; // ((Mathf.Round(newRotation.z / 90)) * 90);

        transform.eulerAngles = newRotation;
        // Debug.Log(transform.eulerAngles + "Rotation After");
    }
}
