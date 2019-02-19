using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalKeys : MonoBehaviour
{

    public float speed = 10.0f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 velocity = new Vector2(x, y);
        GetComponent<Rigidbody2D>().velocity = velocity * speed;


    }

    public void MoveUp()
    {

    }

    public void MoveDown()
    {

    }

    public void MoveRight()
    {

    }

    public void MoveLeft()
    {

    }

}
