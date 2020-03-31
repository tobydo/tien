using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera cameraOne;
    public Camera cameraTwo;
    public bool cameraOneOn;
    
    
    // Start is called before the first frame update
    void Start()
    {
        cameraOne.enabled = true;
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) && cameraOneOn ==false){
            cameraOne.enabled = true;
            cameraTwo.enabled = false;
            cameraOneOn = true;
        }
        if(Input.GetKeyDown(KeyCode.D) && cameraOneOn ==true){
            cameraOne.enabled = true;
            cameraTwo.enabled = false;
            cameraOneOn = false;
        }
    }

}
