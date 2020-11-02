using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class backToMenu : MonoBehaviour
{

    void Update()
    {
if (Input.GetKey(KeyCode.Space))
        {
            BckToMainMenu();
        }
    }

    public void BckToMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }


}
