using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snapOnGrid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

   public void OnSet()
    {
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;
        transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), Mathf.Round(z));

    }


}
