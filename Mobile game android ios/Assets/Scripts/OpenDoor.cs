using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject Door;
    public bool YouHaveKey;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Door.SetActive(false);
        Debug.Log("You have a key");
        Destroy(gameObject);
    }
}
