using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleKeyboardControls : MonoBehaviour
{
    public GameObject TOMMY;
    
    public void Keyboard()
    {
        TOMMY.GetComponent<Movement>().enabled = true;
        TOMMY.GetComponent<PlayerAnimationControl>().enabled = true;
       
    }
    
    public void TouchControls()
    {
        TOMMY.GetComponent<Movement>().enabled = false;
        TOMMY.GetComponent<PlayerAnimationControl>().enabled = false;
    }
    
}
