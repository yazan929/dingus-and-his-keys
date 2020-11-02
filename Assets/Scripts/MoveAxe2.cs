using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAxe2 : MonoBehaviour
{

        // this script wasn't used because axe was removed from the game
//     public bool goToPlayer;
//     public bool fire;
//     public AudioSource axeRef;
//     public bool turn;
//     Vector3 newSport;
//     Vector3 myVector;
//     public float speed;
//     // Start is called before the first frame update
//     void Start()
//     {
//         if (ChickenMovement.current) newSport = new Vector3(ChickenMovement.current.transform.position.x, 1.3f, ChickenMovement.current.transform.position.z);

//         StartCoroutine(killAxe());           
//         myVector = new Vector3(0.0f, 1.3f, 0.0f);
//         transform.LookAt(myVector);
//     }

//     // Update is called once per frame
//     void FixedUpdate()
//     {
//         if(fire){
//         transform.LookAt(newSport);
//         transform.position += transform.forward * speed;
//         StartCoroutine(fireAxeTurn());  
//         }else if(!turn){
//         transform.position += transform.forward * speed;
//         }else{
//         transform.position += transform.forward * -speed;
//         }


//     }
// void Update() {
//         if (ChickenMovement.current) newSport = new Vector3(ChickenMovement.current.transform.position.x, 1.3f, ChickenMovement.current.transform.position.z);
// }
//          IEnumerator fireAxeTurn(){

//             yield return new WaitForSeconds(5);
//             if(!goToPlayer){
//             transform.LookAt(newSport);
//             goToPlayer = true;
//             }
            
//     }
//      IEnumerator killAxe(){
//         yield return new WaitForSeconds(12);
//         Destroy(gameObject);      

                            
            
//     }


}
