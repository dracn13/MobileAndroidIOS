using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleKeyboardControls : MonoBehaviour
{
    public GameObject TOMMY;
    public RawImage OnKeyboard;
    public RawImage OnTouch;

    public void Keyboard()
    {
        TOMMY.GetComponent<Movement>().enabled = true;
        TOMMY.GetComponent<PlayerAnimationControl>().enabled = true;
        OnKeyboard.GetComponent<RawImage>().enabled = true;
        OnTouch.GetComponent<RawImage>().enabled = false;

    }
    
    public void TouchControls()
    {
        TOMMY.GetComponent<Movement>().enabled = false;
        TOMMY.GetComponent<PlayerAnimationControl>().enabled = false;
        OnKeyboard.GetComponent<RawImage>().enabled = false;
        OnTouch.GetComponent<RawImage>().enabled = true;

    }
    
}
