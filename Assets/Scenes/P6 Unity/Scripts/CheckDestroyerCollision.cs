using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDestroyerCollision : MonoBehaviour
{
    public static bool brickOnDestroyer = false;
    void OnTriggerEnter(Collider other)
    {
        // Destroy(other.gameObject);
        brickOnDestroyer = true;
    }

    void OnTriggerExit(Collider other)
    {
        brickOnDestroyer = false;
    }
}
