using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Teil von Pauls Feature
public class ControlDestroyer : MonoBehaviour
{
    public GameObject Destroyer;
    // public GameObject Cube1;
    // public GameObject Cube2;
    public Material normalDestroyerMaterial;
    private float brickScale;
    private float brickSpeed = 5f;
    private bool isDestroyed = false;
    private Material cubeSkyBox;

    void Start(){
        brickScale = this.transform.localScale.x; //alle Koordinaten der bricks haben den gleichen Scale
    }

    public void activateDestroyMode(){ 
        //blende Destroyer auf der linken oder rechten Seite neben der Hotbar ein, je nachdem wo der Brick gegriffen wird:
        // if(transform.position.x > 0){
        //     Destroyer.transform.position = new Vector3(0.28f, Destroyer.transform.position.y, Destroyer.transform.position.z);
        // } else{
        //     Destroyer.transform.position = new Vector3(-0.28f, Destroyer.transform.position.y, Destroyer.transform.position.z);
        // }
        Destroyer.SetActive(true);
    }
    public void deactivateDestroyMode(){
        Destroyer.SetActive(false);
    }
    public void checkDestruction(){
        if(CheckDestroyerCollision.brickOnDestroyer){
            isDestroyed = true;  
        }
    }

    void Update(){
            //Animation, bevor Brick zerstört wird:
            if(isDestroyed == true){
            brickScale -= brickSpeed * Time.deltaTime;
            this.transform.localScale = new Vector3(brickScale, brickScale, brickScale);

            if(brickScale <= 0){
                CheckDestroyerCollision.brickOnDestroyer = false;
                // Cube1.GetComponent<MeshRenderer> ().material = normalDestroyerMaterial;
                // Cube2.GetComponent<MeshRenderer> ().material = normalDestroyerMaterial;

                Destroyer.GetComponent<MeshRenderer> ().material = normalDestroyerMaterial;

                Destroy(this.gameObject); 
            }
        }    }
}
