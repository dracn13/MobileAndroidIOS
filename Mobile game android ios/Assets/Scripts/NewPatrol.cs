using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPatrol : MonoBehaviour
{
    public KillerAI other;
    public GameObject Trigger2;

    void OnTriggerEnter2D(Collider2D collision)
    {
        other.Patrol2();
    }

}
