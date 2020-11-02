using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Walking : MonoBehaviour
{

    public bool played = true;
    public float jump;
    public bool hasKey;
    AudioSource audioData;

    public AudioSource water;
    public AudioSource cantCast;
    public float speed;
    Rigidbody rb;
    Vector3 moveInput;
    Animator animator;

    public bool soundStarted = false;
    int waiting = 0;

    public bool left, right, forward, backward;

    public bool Cleft = true, Cright = true, Cforward = true, Cbackward = true, Cjump = true;

    public bool death=false;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }


    public void ChangeDirection()
    {




        if (forward == true)
        {
            forward = false;
            backward = true;
            left = false;
            right = false;
        }
        else if (backward == true)
        {
            backward = false;
            forward = true;
            left = false;
            right = false;
        }
        else if (left == true)
        {
            left = false;
            right = true;
            forward = false;
            backward = false;

        }
        else if (right == true)
        {
            forward = false;
            backward = false;
            right = false;
            left = true;
        }


    }


    void Update(){
                 if(death){

                water.Play();
             
        StartCoroutine(wait());
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
        }


            if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Cjump == true)
            {
                rb.AddForce(Vector2.up * jump * 2f);
                Cjump=false;
            }

        }



    }

    void FixedUpdate()
    {




        if ((Input.GetKey(KeyCode.R))) {
            SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
        }

        if ((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.A)))
        {
            if (!soundStarted)
            {

                animator.SetBool("Walk", true);
                audioData.Play();
                soundStarted = true;
            }


        }



        if (Input.GetKey(KeyCode.W))
        {

            if (Cforward == true)
            {
                TurnF();
            }
            if (Cforward == false)
            {
                PlayCantSound();
            }

        }
        if (Input.GetKey(KeyCode.S))
        {
            if (Cbackward == false)
            {
                PlayCantSound();
            }
            if (Cbackward == true)
            {
                TurnB();
            }


        }
        if (Input.GetKey(KeyCode.A))
        {
            if (Cleft == false)
            {
                PlayCantSound();
            }
            if (Cleft == true)
            {
                TurnRight();
            }


        }

        if (Input.GetKey(KeyCode.D))
        {
            if (Cright == false)
            {
                PlayCantSound();
            }
            if (Cright == true)
            {
                TurnLeft();
            }

        }




        if (backward)
        {
            transform.rotation = Quaternion.Euler(0, 100, 0);
            transform.position += Vector3.right * speed * Time.deltaTime;

        }

        if (forward)
        {
            transform.rotation = Quaternion.Euler(0, -100, 0);
            transform.position += Vector3.left * speed * Time.deltaTime;

        }

        if (left)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            transform.position += -Vector3.forward * speed * Time.deltaTime;

        }


        if (right)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.position += Vector3.forward * speed * Time.deltaTime;

        }



    }




    IEnumerator wait()
    {

        yield return new WaitForSeconds(2);


    }

    public void PlayCantSound()
    {
        cantCast.Play();

    }

    public void TurnRight()
    {
        forward = false;
        left = true;
        right = false;
        backward = false;
        StartCoroutine(wait());
        Cleft = false;
    }

    public void TurnLeft()
    {
        forward = false;
        left = false;
        right = true;
        backward = false;
        StartCoroutine(wait());
        Cright = false;
    }

    public void TurnF()
    {
        forward = true;
        left = false;
        right = false;
        backward = false;
        StartCoroutine(wait());
        Cforward = false;
    }

    public void TurnB()
    {
        forward = false;
        left = false;
        right = false;
        backward = true;
        StartCoroutine(wait());
        Cbackward = false;
    }



}
