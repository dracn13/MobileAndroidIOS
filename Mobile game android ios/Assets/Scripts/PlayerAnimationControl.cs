using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Horizontal") != 0)
        {
            float x = Input.GetAxis("Horizontal");
            GetComponent<Animator>().SetFloat("x", x);
            GetComponent<Animator>().SetFloat("y", 0);
            GetComponent<Animator>().SetBool("Idle", false);
        }else if (Input.GetAxis("Vertical") != 0)
        {
            float y = Input.GetAxis("Vertical");
            GetComponent<Animator>().SetFloat("y", y);
            GetComponent<Animator>().SetFloat("x", 0);
            GetComponent<Animator>().SetBool("Idle", false);
        }else
        {
            GetComponent<Animator>().SetBool("Idle", true);
            GetComponent<Animator>().SetFloat("y", 0);
            GetComponent<Animator>().SetFloat("x", 0);
        }
    }
}
