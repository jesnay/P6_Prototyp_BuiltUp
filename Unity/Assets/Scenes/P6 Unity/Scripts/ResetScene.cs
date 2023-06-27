using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{

    public GameObject mainCamera;
    public void Update()
    {
        transform.position = mainCamera.transform.position + Vector3.forward * -0.4f + Vector3.up * -0.5f;
    }
    public void SceneReset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
