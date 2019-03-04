using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPatrol : MonoBehaviour
{
    public GameObject Trigger1;

    void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.GetComponent<KillerAI>().Patrol2
    }

}