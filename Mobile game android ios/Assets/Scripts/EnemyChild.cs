using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChild : MonoBehaviour
{
    public GameObject Mother;
    public float chaseSpeed = 10.0f;
    public float chaseTriggerDistance = 10.0f;
    Vector3 startPosition;
    public Vector3 paceDirection = new Vector3(0, 0, 0);



    // Start is called before the first frame update
    void Start()
    {
        Mother = GameObject.FindGameObjectWithTag("Boss");
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 playerPosition = Mother.transform.position;
        //vector form enemy position to the players position
        Vector3 chaseDirection = playerPosition - transform.position;
        if (chaseDirection.magnitude < chaseTriggerDistance)
        {
            //chase because the palyer is close to the enemy
            chaseDirection.Normalize();
            GetComponent<Rigidbody2D>().velocity = chaseDirection * chaseSpeed;
        }


    }
}
