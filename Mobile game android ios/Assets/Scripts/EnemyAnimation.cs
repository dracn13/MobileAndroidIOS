using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            float x = Input.GetAxis("Horizontal");
            GetComponent<Animator>().SetFloat("x", x);
            GetComponent<Animator>().SetFloat("y", 0);
            GetComponent<Animator>().SetBool("idle", false);
        }
        else if (Input.GetAxis("Vertical") != 0)
        {
            float y = Input.GetAxis("Vertical");
            GetComponent<Animator>().SetFloat("y", y);
            GetComponent<Animator>().SetFloat("x", 0);
            GetComponent<Animator>().SetBool("idle", false);
        }
        else
        {
            GetComponent<Animator>().SetBool("idle", true);
            GetComponent<Animator>().SetFloat("y", 0);
            GetComponent<Animator>().SetFloat("x", 0);
        }
    }
}
