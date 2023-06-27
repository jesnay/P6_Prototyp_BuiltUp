using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RecenterOrigin : MonoBehaviour
{
    public Transform mainCamera;
    public Transform origin;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
   
        Vector3 offset = mainCamera.position - origin.position;
        origin.position = target.position - offset;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
