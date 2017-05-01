using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealt : MonoBehaviour
{
    private int health = 100;
    public Text HealthText;
    void Start ()
    {
        HealthText.text = "HP: " + health;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health = health - 1;
            HealthText.text = "HP: " + health;
            if (health == 0)
            {
                Application.LoadLevel(2);
            }            
        }
    }
}
