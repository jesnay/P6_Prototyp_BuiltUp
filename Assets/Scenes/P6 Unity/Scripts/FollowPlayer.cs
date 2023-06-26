using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject mainCamera;
    private float yPos;
    private float xRot;

    // Start is called before the first frame update
    void Start()
    {
        yPos = transform.position.y;
        xRot = transform.rotation.x;
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = mainCamera.transform.position + Vector3.down * 0.7f + Vector3.forward * 0.5f;
        //  transform.position = Vector3.MoveTowards(transform.position, mainCamera.transform.position+Vector3.forward*0.5f, 6 * Time.deltaTime);
        Vector3 targetPosition = new Vector3(-mainCamera.transform.position.x, transform.position.y -xRot, -mainCamera.transform.position.z);

        Debug.Log(targetPosition);
        transform.LookAt(targetPosition);
        // Debug.Log(mainCamera.transform.forward + "und" + mainCamera.transform.up);
        transform.position = new Vector3(mainCamera.transform.position.x + mainCamera.transform.forward.x/2, yPos, mainCamera.transform.position.z + mainCamera.transform.forward.z/2);

    }
}
