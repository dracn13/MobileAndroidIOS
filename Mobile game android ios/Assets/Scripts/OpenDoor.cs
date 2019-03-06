using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor : MonoBehaviour
{
 
    public int RedKeyCount = 0;
    public int BlueKeyCount = 0;
    public RawImage RedKey;
    public RawImage BlueKey;

     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bluekey")
        {
            BlueKey.GetComponent<RawImage>().enabled = true;
            BlueKeyCount++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Redkey")
        {
            RedKey.GetComponent<RawImage>().enabled = true;
            RedKeyCount++;
            Destroy(collision.gameObject);
            
        }
        if (BlueKeyCount >= 1)
        {
            if (collision.gameObject.tag == "Bluedoor")
            {
                BlueKey.GetComponent<RawImage>().enabled = false;
                Destroy(collision.gameObject);
                BlueKeyCount--;
            }
        }
        if (RedKeyCount >= 1)
        {
            if (collision.gameObject.tag == "Reddoor")
            {
                RedKey.GetComponent<RawImage>().enabled = false;
                Destroy(collision.gameObject);
                RedKeyCount--;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (BlueKeyCount >= 1)
        {
            if (collision.gameObject.tag == "Bluedoor")
            {
                BlueKey.GetComponent<RawImage>().enabled = false;
                Destroy(collision.gameObject);
                BlueKeyCount--;
            }
        }
        if (RedKeyCount >= 1)
        {
            if (collision.gameObject.tag == "Reddoor")
            {
                RedKey.GetComponent<RawImage>().enabled = false;
                Destroy(collision.gameObject);
                RedKeyCount--;
            }
        }
    }

}
