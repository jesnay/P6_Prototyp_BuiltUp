using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;


public class OffGameSettings : MonoBehaviour
{
    private GameObject cameraOffset;
private Vector3 mainCameraPos;
    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = GameObject.Find("CameraOffset");
        cameraOffset.transform.position = new Vector3(0f, 1.4f, 0.5f);

mainCameraPos=GameObject.Find("MainCamera").transform.position;
        }

    // Update is called once per frame
    void Update()
    {
transform.position=mainCameraPos+new Vector3(0,0,1f);
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}

