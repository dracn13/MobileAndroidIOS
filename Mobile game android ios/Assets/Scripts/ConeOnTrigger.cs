using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeOnTrigger : MonoBehaviour
{

    public KillerAI KillerAI;


    void OnTriggerEnter2D(Collider2D o)
    {

        if (o.gameObject.tag == "Player")
        {
            KillerAI.inViewCone = true;
        }
    }

    void OnTriggerExit2D(Collider2D o)
    {

        if (o.gameObject.tag == "Player")
        {
            KillerAI.inViewCone = false;
        }
    }
}