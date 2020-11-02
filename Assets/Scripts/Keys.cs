using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{

    public GameObject W,A,S,D,space;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            W.SetActive (true);
        }

        if (Input.GetKey(KeyCode.A))
        {
            A.SetActive (true);
        }

        if (Input.GetKey(KeyCode.S))
        {
           S.SetActive (true);
        }

        if (Input.GetKey(KeyCode.D))
        {
            D.SetActive (true);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            space.SetActive (true);
        }
    }
}
