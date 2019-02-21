using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    public GameObject player;
    public float chaseSpeed = 3.0f;
    public float chaseTriggerDistance = 3.0f;
    Vector3 startPosition;
    bool home = true;
    public Vector3 paceDirection = new Vector3(0, 0, 0);
    public float paceDistance = 3.0f;
    public float paceSpeed = 2.0f;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = player.transform.position;
        //vector form enemy position to the players position
        Vector3 chaseDirection = playerPosition - transform.position;
        if (chaseDirection.magnitude < chaseTriggerDistance)
        {
            //chase because the palyer is close to the enemy
            home = false;
            chaseDirection.Normalize();
            GetComponent<Rigidbody2D>().velocity = chaseDirection * chaseSpeed;
        }
        else if (home == false)
        {
            //see how far away we are from home 
            Vector3 homeDirection = startPosition - transform.position;
            // if we get close to home reset our position to home and rest velocity
            if (homeDirection.magnitude < 0.3f)
            {
                home = true;
                transform.position = startPosition;
                GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
            }
            else
            {
                //go home
                homeDirection.Normalize();
                GetComponent<Rigidbody2D>().velocity = homeDirection * paceSpeed;
            }
        }
        else
        {
            //pace back and forth, because we`re home and the player isint close
            Vector3 displacement = transform.position - startPosition;
            float distanceFromStart = displacement.magnitude;
            if (distanceFromStart >= paceDistance)
            {
                //flip direction
                paceDirection = -paceDirection;
            }
            paceDirection.Normalize();
            GetComponent<Rigidbody2D>().velocity = paceDirection * paceSpeed;

        }
    }
}
