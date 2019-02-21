using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public int Health = 10;
    public Text healthText;
    public Slider healthBar;
    float timer = 0;

    void Update()
    {
        timer += Time.deltaTime;
    }
    void Start()
    {
        healthText.GetComponent<Text>().text = "Health: " + Health;
        healthBar.GetComponent<Slider>().value = Health;
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (timer > 0.5f && collision.gameObject.tag == "Enemy" || timer > 0.5f && collision.gameObject.tag == "Boss")
        {
            timer = 0;
            Health--;
            healthText.GetComponent<Text>().text = "Health: " + Health;
            healthBar.GetComponent<Slider>().value = Health;
            if (Health <= 0)

            {
                Time.timeScale = 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

}



//void OnCollisionEnter2D(Collision2D collision)
//{
   // if (collision.gameObject.tag == "Enemy")
   // {
      //  Health--;
       // healthText.GetComponent<Text>().text = "Health: " + Health;
       // healthBar.GetComponent<Slider>().value = Health;
       // if (Health <= 0)

       // {
            //Reload the level
       //     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       // }
   // }
//}
