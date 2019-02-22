using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerAI : MonoBehaviour
{

    public GameObject player;
    public float chaseSpeed = 3.0f;
    public float chaseTriggerDistance = 3.0f;
    Vector3 startPosition;
    bool home = true;
    public Vector3 paceDirection = new Vector3(0, 0, 0);
    public float paceDistance = 3.0f;
    public float paceSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = player.transform.position;

    }
}
