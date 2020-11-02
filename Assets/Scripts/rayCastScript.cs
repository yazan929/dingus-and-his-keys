using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class rayCastScript : MonoBehaviour
{

        // this script wasn't used because axe was removed from the game
    // public AudioSource axeRef;
    // public LayerMask axeLayer;
    // void Update()
    // {   
    //     if (Input.touchCount == 2 && Input.touches[1].phase == TouchPhase.Began){ 

    //         RaycastHit hit; 
    //         Ray ray = Camera.main.ScreenPointToRay(Input.touches[1].position); 

    //         if (Physics.Raycast (ray,out hit, Mathf.Infinity, axeLayer)){

    //             MoveAxe2 axeScript = hit.transform.GetComponent<MoveAxe2>();
    //             if (!axeScript.turn) axeRef.Play();
    //             if (axeScript) axeScript.turn = true;
    //         }
    //     }

    //     else if (Input.touchCount == 1 && Input.touches[0].phase == TouchPhase.Began){ 

    //         RaycastHit hit; 
    //         Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position); 

    //         if (Physics.Raycast (ray,out hit, Mathf.Infinity, axeLayer)){

    //             MoveAxe2 axeScript = hit.transform.GetComponent<MoveAxe2>();
    //             if (!axeScript.turn) axeRef.Play();
    //             if (axeScript) axeScript.turn = true;
    //         }
    //     }
    // }
}
 