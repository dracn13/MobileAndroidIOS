using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPatrol3 : MonoBehaviour
{
    public KillerAI other;
    public GameObject Trigger3;

    void OnTriggerEnter2D(Collider2D collision)
    {
        other.Patrol4();
    }

}
