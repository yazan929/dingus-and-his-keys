using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trees : MonoBehaviour
{

    public bool touch= false;

    public AudioSource bump;
    [SerializeField] public Walking chickenWalk;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            chickenWalk.ChangeDirection();
            bump.Play();


        }
    }



}
