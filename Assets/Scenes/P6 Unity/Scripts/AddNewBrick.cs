using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddNewBrick : MonoBehaviour
{

    // public GameObject[] bricks=new GameObject[9];
    public GameObject brick;

    public bool wasSelectedFirstTime=false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddBuildingBrick()
    {
        if (wasSelectedFirstTime == false)
        {

            Instantiate(brick, new Vector3(-0.4f, 1.2f, -0.2f), transform.rotation);
            wasSelectedFirstTime = true;
        }
    }
}
