using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class fakeState : MonoBehaviour
{
    public Sprite[] titleCards;
    public int titleNumber;
    public Image image;
    public Text fakeUI;
    public string[] fakeUIText;
    public int fakeUINumber;
    public bool imageShowing;

    // Start is called before the first frame update
    void Start()
    {
        imageShowing =false;
        image.enabled= false;
        
    }
    void Update(){
        fakeUI.text = fakeUIText[fakeUINumber];
       if(Input.GetMouseButtonDown(0)&&imageShowing ==false)
       {
        image.sprite = titleCards[titleNumber];
        image.enabled =true;
        fakeUI.enabled =false;
        imageShowing = true;
         if(fakeUINumber<fakeUIText.Length-1)
             {
                fakeUINumber++;
            }
       }
            
        else if(Input.GetMouseButtonDown(0)&&imageShowing ==true){
        image.enabled =false;
        fakeUI.enabled = true;
         if(titleNumber< titleCards.Length-1)
         {
         titleNumber++;
         }
        
         imageShowing = false;
        }
    }

    // Update is called once per frame
    

     
    
}
