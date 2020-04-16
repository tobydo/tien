using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.UI;

public class StateMachineTest : MonoBehaviour
{
    public KeyCode buttonOne;
    public KeyCode buttonTwo;
    public KeyCode buttonThree;
     public TextAsset Scene;
        string [] lines;
    string  speaker;
    public TextMeshProUGUI talking;
    public int currentLine;
    public enum Characters{
        Tien,
        Duc,
        Jun
    }
    public enum Cameras
    {

    One,
    Two,
    Three
    }
    public Camera currentCamera{
        get{
            return cameraOn[(int)current];
        }
    }

    public bool[] whoCanWeSee{
        get{
            switch(current){
                default: return VisOne; break;
            case Cameras.One: return VisOne; break;
            case Cameras.Two: return VisTwo; break;
            case Cameras.Three: return VisThree; break;
        }
        }
    }
   
    
    [NamedArray(typeof(Characters))] public bool[] VisOne;
    [NamedArray(typeof(Characters))] public bool[] VisTwo;
    [NamedArray(typeof(Characters))] public bool[] VisThree;


    [NamedArray(typeof(Cameras))] public Camera[] cameraOn;
    public Cameras current;

    
    // Start is called before the first frame update
    void Start()
    {
        currentCamera.enabled = true;
        current = Cameras.One;
        Debug.Log(currentCamera);

        string sceneString = Scene.text;
        lines = sceneString.Split('\n');
        currentLine = 0;
       

       
        
    }

    // Update is called once per frame
    void Update()
    {
       // talking.text = lines[currentLine];

          if(Input.GetKeyDown(buttonOne)){
             current = Cameras.One;
            
                foreach(Camera camera in cameraOn){
                camera.enabled = false;
                }
            currentCamera.enabled = true;
            
           
          }                                 
        if(Input.GetKeyDown(buttonTwo)) {
          current = Cameras.Two;
            
                foreach(Camera camera in cameraOn){
                camera.enabled = false;
                }
            currentCamera.enabled = true;
          
        }
        if(Input.GetKeyDown(buttonThree)) {
           current = Cameras.Three;
            
                foreach(Camera camera in cameraOn){
                camera.enabled = false;
                }
            currentCamera.enabled = true;
            
        }

        if(Input.GetMouseButton(0)){
            Dialogue();
        }

        

        // swith if cameraOne then tien=true and duc=true
    }

    void Dialogue() {
            
        //Debug.Log("we can talk");
        speaker = lines[currentLine].Split(':')[0];
        string currentText = lines[currentLine].Split(':')[1];

        Characters talk = (Characters) System.Enum.Parse(typeof(Characters), speaker);

        if(whoCanWeSee[(int)talk]){
           currentLine++;
        }


        

    }

    public void Switch(){
       current = Cameras.Three;
            
                foreach(Camera camera in cameraOn){
                camera.enabled = false;
                }
            currentCamera.enabled = true;
             buttonOne = KeyCode.None;
     buttonTwo= KeyCode.None ;
        }

       
    
}
