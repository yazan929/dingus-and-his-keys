using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ChickenMovement : MonoBehaviour
{


    public AudioSource chick;
    public ParticleSystem sys;
    private Animator anim;
    public float moveSpeed;
    public float rotationSpeed;
    Vector3 moveInput;
    bool moving;

    public static ChickenMovement current;

    void Awake() {
        current = this;
    }

    void OnDisable(){

        current = null;

    }

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update(){


    }

    void FixedUpdate(){


    }





}