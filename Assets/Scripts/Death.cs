﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    // Start is called before the first frame update

        [SerializeField] public Walking checkKey;
void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            checkKey.death = true;
        }
        }
}
