using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thorwingAxes : MonoBehaviour
{
    
     // this script wasn't used because axe was removed from the game
    // public GameObject axe;
    // public GameObject hardAxe;
    // public GameObject fireAxe;
    // public bool startEasy = true;

    // public bool destroyAll;

    // public bool startHard;
    // // Start is called before the first frame update
    // void Start()
    // {
    //     StartCoroutine(throwAxe1());  
    //     StartCoroutine(throwAxe2());  
    //     StartCoroutine(fireAxeT()); 


    // }
    // private Vector3 RandomPointOnCircleEdge(float radius){

    //     var vector2 = UnityEngine.Random.insideUnitCircle.normalized * radius;
    //     return new Vector3(vector2.x, 0, vector2.y);
    // }
    // void Update() {

    //     if(startHard)if(!destroyAll){
    //         destroyAll=true;
    //         GameObject[] gameObjects = GameObject.FindGameObjectsWithTag ("Axe");
    //         for(var i = 0 ; i < gameObjects.Length ; i ++){
    //             Destroy(gameObjects[i]);
    //         }
    //     }            

    // }
    // // Update is called once per frame



    // IEnumerator throwAxe1(){
    //         while(startEasy){

    //         Instantiate(axe, transform.position + RandomPointOnCircleEdge(8), Quaternion.identity);
    //         yield return new WaitForSeconds(4);

                            
    //         }
    //         while(startHard){

    //         Instantiate(axe, transform.position + RandomPointOnCircleEdge(8), Quaternion.identity);
    //         yield return new WaitForSeconds(4);

                            
    //         }            
    // }

    // IEnumerator throwAxe2(){
            
    //         if(startEasy) yield return new WaitForSeconds(10);

    //         while(startEasy){

    //         Instantiate(axe, transform.position + RandomPointOnCircleEdge(7), Quaternion.identity);
    //         yield return new WaitForSeconds(8);
                 
    //         }
    //         yield return new WaitForSeconds(2);

    //         while(startHard){

    //         Instantiate(axe, transform.position + RandomPointOnCircleEdge(7), Quaternion.identity);
    //         yield return new WaitForSeconds(4);
                 
    //         }            
    // }

    // IEnumerator fireAxeT(){
    //         while(startEasy){

    //         if(startEasy) yield return new WaitForSeconds(20);

    //         Instantiate(fireAxe, transform.position + RandomPointOnCircleEdge(8), Quaternion.identity);
    //         yield return new WaitForSeconds(7);

                            
    //         }
    //         while(startHard){

    //         yield return new WaitForSeconds(10);

    //         Instantiate(fireAxe, transform.position + RandomPointOnCircleEdge(8), Quaternion.identity);
    //         yield return new WaitForSeconds(7);

                            
    //         }
    // }



}
