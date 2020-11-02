using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class winlast : MonoBehaviour
{

    [SerializeField] public keyMovement key1;
    [SerializeField] public keyMovement key2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((key1.keySound == true) && (key2.keySound == true))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
