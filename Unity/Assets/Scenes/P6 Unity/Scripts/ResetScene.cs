using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{

    public GameObject mainCamera;

    public GameObject[] bricktags;
    public GameObject[] flattags;
    public GameObject[] high2Xtagss;
    public GameObject[] high4Xtagss;
    public GameObject[] flagtags;



    public void Update()
    {
        transform.position = mainCamera.transform.position + Vector3.forward * -0.4f + Vector3.up * -0.5f;
    }
    public void SceneReset()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        // Get all gameObjects with specific tag
        // Solution to find every GameObject with tags, because GameObject can only have on tag
        bricktags = GameObject.FindGameObjectsWithTag("brick");
        flagtags = GameObject.FindGameObjectsWithTag("flag");
        high2Xtagss = GameObject.FindGameObjectsWithTag("high 2x");
        high4Xtagss = GameObject.FindGameObjectsWithTag("high 4x");
        flattags = GameObject.FindGameObjectsWithTag("flat");

        if (bricktags != null)
        {

            foreach (GameObject g in bricktags)
            {
                if (g.GetComponent<AddNewBrick>().isPlaced)
                {
                    Destroy(g.gameObject);
                }
                // Destroys all gameObject which are not in the hotbar
            }
        }
        if (flagtags != null)
        {

            foreach (GameObject g in flagtags)
            {
                if (g.GetComponent<AddNewBrick>().isPlaced)
                {
                    Destroy(g.gameObject);
                }
            }
        }
        if (high2Xtagss != null)
        {

            foreach (GameObject g in high2Xtagss)
            {
                if (g.GetComponent<AddNewBrick>().isPlaced)
                {
                    Destroy(g.gameObject);
                }
            }
        }
        if (high4Xtagss != null)
        {

            foreach (GameObject g in high4Xtagss)
            {
                if (g.GetComponent<AddNewBrick>().isPlaced)
                {
                    Destroy(g.gameObject);
                }
            }
        }
        if (flattags != null)
        {

            foreach (GameObject g in flattags)
            {
                if (g.GetComponent<AddNewBrick>().isPlaced)
                {
                    Destroy(g.gameObject);
                }
            }
        }

    }

}

