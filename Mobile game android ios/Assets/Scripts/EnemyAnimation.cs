using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    public Rigidbody2D Child;
    public Animator ChildAmine;

    // Update is called once per frame
    void Update()
    {
        float x = Child.velocity.x;
        float y = Child.velocity.y;
        
        if(x < 0)
        {
            ChildAmine.SetFloat("x", x);
            ChildAmine.SetFloat("y", 0);
            ChildAmine.SetBool("idle", false);
        }

        if (x > 0)
        {
            ChildAmine.SetFloat("x", x);
            ChildAmine.SetFloat("y", 0);
            ChildAmine.SetBool("idle", false);
        }

        if (y > 0)
        {
            ChildAmine.SetFloat("y", y);
            ChildAmine.SetFloat("x", 0);
            ChildAmine.SetBool("idle", false);
        }

        if (y < 0)
        {
            ChildAmine.SetFloat("y", y);
            ChildAmine.SetFloat("x", 0);
            ChildAmine.SetBool("idle", false);
        }

        if (x == 0 && y == 0)
        {
            ChildAmine.SetBool("idle", true);
            ChildAmine.SetFloat("y", 0);
            ChildAmine.SetFloat("x", 0);
        }
    }
}
