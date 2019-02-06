using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Transform player;
    public float Speed = 5.0f;
    private bool TouchStart = false;
    private Vector2 pointA;
    private Vector2 pointB;

    public Transform Circle;
    public Transform OuterCircle;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetMouseButtonDown(0))
        {
            pointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));

            Circle.transform.position = pointA * 1;
            OuterCircle.transform.position = pointA * 1;
            Circle.GetComponent<SpriteRenderer>().enabled = true;
            OuterCircle.GetComponent<SpriteRenderer>().enabled = true;
        }
        if(Input.GetMouseButton(0))
        {
            TouchStart = true;
            pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
        }
        else
        {
            TouchStart = false;
        }
	}

    private void FixedUpdate()
    {
        if(TouchStart)
        {
            Vector2 offset = pointB - pointA;
            Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);
            moveCharacter(direction * -1);

            Circle.transform.position = new Vector2(pointA.x + direction.x, pointA.y + direction.y) * 1;
        }
        else
        {
            Circle.GetComponent<SpriteRenderer>().enabled = false;
            OuterCircle.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    void moveCharacter(Vector2 direction)
    {
        player.Translate(direction * Speed * Time.deltaTime);
    }
}
