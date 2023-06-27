using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;


public class OffGameSettings : MonoBehaviour
{
    public GameObject cameraOffset;
    public GameObject mainCamera;
    public GameObject XROrigin;

    public GameObject canvasForResetButton;
    // Start is called before the first frame update
    void Start()
    {
        // cameraOffset.transform.position = new Vector3(5f, 1.4f, 0.5f);
        // XROrigin.transform.position = new Vector3(0f, 0f, -0.8f);

        // mainCamera.transform.position = new Vector3(5, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        canvasForResetButton.transform.position = mainCamera.transform.position + new Vector3(0f, -0.5f, -0.4f);
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}

