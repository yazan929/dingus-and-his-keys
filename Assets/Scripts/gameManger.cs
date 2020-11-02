using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManger : MonoBehaviour
{
    public static bool paused;

    public GameObject pauseMenu;
    public GameObject blocker;

    public GameObject Joystick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


            if (Input.GetKeyUp(KeyCode.D))
            {
                if(!paused){
                    
                    Time.timeScale =0;
                    blocker.SetActive(true);
                    Joystick.SetActive(false);                    
                    pauseMenu.SetActive(true);



                    paused= true;
                }else{
                    pauseMenu.SetActive(false);
                    blocker.SetActive(false);
                    Joystick.SetActive(true);
                    Time.timeScale =1;

                    paused=false;
                }
 
             
            }        
    }
}
