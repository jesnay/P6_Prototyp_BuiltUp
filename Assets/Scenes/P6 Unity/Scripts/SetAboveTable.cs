using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAboveTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        // other.gameObject.transform.position = new Vector3(other.gameObject.transform.position.x, 0.09f, other.gameObject.transform.position.z);
    }

}
