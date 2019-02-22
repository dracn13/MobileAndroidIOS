using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
 
    public int RedKeyCount = 0;
    public int BlueKeyCount = 0;

     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bluekey")
        {
            
            BlueKeyCount++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Redkey")
        {
            
            RedKeyCount++;
            Destroy(collision.gameObject);
        }
        if (BlueKeyCount >= 1)
        {
            if (collision.gameObject.tag == "Bluedoor")
            {
                Destroy(collision.gameObject);
                BlueKeyCount--;
            }
        }
        if (RedKeyCount >= 1)
        {
            if (collision.gameObject.tag == "Reddoor")
            {
                Destroy(collision.gameObject);
                RedKeyCount--;
            }
        }
    }
    


}
