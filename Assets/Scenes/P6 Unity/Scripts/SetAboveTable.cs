using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAboveTable : MonoBehaviour
{
public TableHeight yPosTable;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    public void KeepAboveTable()
    {
        if (transform.position.y < yPosTable.tableHeight)
        {
            transform.position = new Vector3(transform.position.x, yPosTable.tableHeight, transform.position.z);
        }
    }

}
