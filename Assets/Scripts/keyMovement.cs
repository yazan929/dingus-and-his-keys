using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyMovement : MonoBehaviour
{
    public bool keySound;
    public float speed = 2;

    public GameObject doorBlock;
 public Renderer rend;
     public AudioSource collectKey;
    [SerializeField] public Walking checkKey;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

         rend.enabled = false;


            checkKey.hasKey = true;

            if(keySound==false){
            collectKey.Play();
            keySound=true;
            }

            Destroy (doorBlock);

        }
    }


}
