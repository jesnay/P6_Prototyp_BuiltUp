using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDestroyer : MonoBehaviour
{
    public GameObject Destroyer;
    public GameObject Cube1;
    public GameObject Cube2;
    public Material normalDestroyerMaterial;
    // private MeshRenderer brickColor;
    // private float brickAlpha = 1f;
    private float brickScale;
    private float brickSpeed = 5f;
    private bool isDestroyed = false;

    void Start(){
        brickScale = this.transform.localScale.x; //alle Koordinaten der bricks haben den gleichen Scale
        // brickColor = this.gameObject.GetComponent<MeshRenderer> ();
        // Debug.Log(brickColor);

    }

    public void activateDestroyMode()
    {
        Destroyer.SetActive(true);
    }
    public void deactivateDestroyMode()
    {
        Destroyer.SetActive(false);
    }
    public void checkDestruction(){
        if(CheckDestroyerCollision.brickOnDestroyer){
            isDestroyed = true;  
        }
    }

    void Update(){
        if(isDestroyed == true){
            
            brickScale -= brickSpeed * Time.deltaTime;
            this.transform.localScale = new Vector3(brickScale, brickScale, brickScale);
            // Debug.Log(brickColor);
            // brickAlpha -= brickSpeed * Time.deltaTime;
            // brickColor.material.SetColor("_Color", Random.ColorHSV());
            // MeshRenderer.material.color = color;
            // new Color(brickColor.r, brickColor.g, brickColor.b, brickAlpha);

            if(brickScale <= 0){
                CheckDestroyerCollision.brickOnDestroyer = false;
                Cube1.GetComponent<MeshRenderer> ().material = normalDestroyerMaterial;
                Cube2.GetComponent<MeshRenderer> ().material = normalDestroyerMaterial;
                Destroy(this.gameObject); 
            }
        }    }
}
