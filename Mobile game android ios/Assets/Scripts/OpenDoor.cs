using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject Door;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Door.SetActive(false);
        Destroy(gameObject);
    }
}
