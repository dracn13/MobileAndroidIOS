using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerACMobile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = GetComponent<Rigidbody2D>().velocity.x;
        float y = GetComponent<Rigidbody2D>().velocity.y;
        bool Idle = true;
        if (x < 0)
        {
            GetComponent<Animator>().SetFloat("x", x);
            GetComponent<Animator>().SetFloat("y", 0);
            GetComponent<Animator>().SetBool("Idle", false);
        }

        if (x > 0)
        {
            GetComponent<Animator>().SetFloat("x", x);
            GetComponent<Animator>().SetFloat("y", 0);
            GetComponent<Animator>().SetBool("Idle", false);
        }

        if (y > 0)
        {
            GetComponent<Animator>().SetFloat("y", y);
            GetComponent<Animator>().SetFloat("x", 0);
            GetComponent<Animator>().SetBool("Idle", false);
        }

        if (y < 0)
        {
            GetComponent<Animator>().SetFloat("y", y);
            GetComponent<Animator>().SetFloat("x", 0);
            GetComponent<Animator>().SetBool("Idle", false);
        }

        if (x == 0 && y == 0)
        {
            GetComponent<Animator>().SetBool("Idle", true);
            GetComponent<Animator>().SetFloat("y", 0);
            GetComponent<Animator>().SetFloat("x", 0);
        }
    }
}
