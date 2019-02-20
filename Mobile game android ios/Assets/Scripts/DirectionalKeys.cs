using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalKeys : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    private float moveDirX = 0;
    private float moveDirY= 0;

    void Start()
    {

    }
    void Update()
    {
        MoveX();
        MoveY();
    }
    void MoveX()
    {
        //player movement up down
        Vector3 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = moveSpeed * moveDirX;
        GetComponent<Rigidbody2D>().velocity = velocity;
    }
    void MoveY()
    {
        //player movement up down
        Vector3 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.y = moveSpeed * moveDirY;
        GetComponent<Rigidbody2D>().velocity = velocity;
    }

    public void MoveRight()
    {
        moveDirX = 1;
    }
    public void MoveLeft()
    {
        moveDirX = -1;
    }
    
    public void MoveUp()
    {
        moveDirY = 1;
    }
    public void MoveDown()
    {
        moveDirY = -1;
    }
    public void Stop()
    {
        moveDirX = 0;
        moveDirY = 0;
    }
}