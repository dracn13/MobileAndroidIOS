using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerAI : MonoBehaviour
{

    // Where is the player
    private Transform playerTransform;

    // FSM related variables
    private Animator animator;
    bool chasing = false;
    bool waiting = false;
    private float distanceFromTarget;
    public bool inViewCone;

    // Where is it going and how fast?
    Vector3 direction;
    private float walkSpeed = 2f;
    private int currentTarget;
    private Transform[] waypoints = null;

    // This runs when the zombie is added to the scene
    private void Awake()
    {
        // Get a reference to the player's transform
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        // Get a reference to the FSM (animator)
        animator = gameObject.GetComponent<Animator>();

        // Add all our waypoints into the waypoints array
        Transform point1 = GameObject.Find("P1").transform;
        Transform point2 = GameObject.Find("P2").transform;
        Transform point3 = GameObject.Find("P3").transform;
        Transform point4 = GameObject.Find("P4").transform;
        Transform point5 = GameObject.Find("P5").transform;
        waypoints = new Transform[5] 
        {
            point1,
            point2,
            point3,
            point4,
            point5
        };

    }

    private void Update()
    {
        // If chasing get the position of the player and point towards it
        if (chasing)
        {
            direction = playerTransform.position - transform.position;
            rotateKiller();
        }

        // Unless the zombie is waiting then move
        if (!waiting)
        {
            transform.Translate(walkSpeed * direction * Time.deltaTime, Space.World);
        }

    }

    private void FixedUpdate()
    {
        // Give the values to the FSM (animator)
        distanceFromTarget = Vector3.Distance(waypoints[currentTarget].position, transform.position);
        animator.SetFloat("distanceFromWaypoint", distanceFromTarget);
        animator.SetBool("playerInSight", inViewCone);

    }

    public void SetNextPoint()
    {
        // Pick a random waypoint 
        // But make sure it is not the same as the last one
        int nextPoint = -1;

        do
        {
            nextPoint = Random.Range(0, waypoints.Length - 1);
        }
        while (nextPoint == currentTarget);

        currentTarget = nextPoint;

        // Load the direction of the next waypoint
        direction = waypoints[currentTarget].position - transform.position;
        rotateKiller();
    }

    public void Chase()
    {
        // Load the direction of the player
        direction = playerTransform.position - transform.position;
        rotateKiller();
    }

    public void StopChasing()
    {
        chasing = false;
    }

    private void rotateKiller()
    {
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));
        direction = direction.normalized;
    }

    public void StartChasing()
    {
        chasing = true;
    }

    public void ToggleWaiting()
    {
        waiting = !waiting;
    }

}