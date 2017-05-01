using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCollision : MonoBehaviour
{
    private GameObject Gamebehaviour;
    private score score;
    void Awake ()
    {
        Gamebehaviour = GameObject.Find("Gamebehaviour");
        score = Gamebehaviour.GetComponent<score>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            score.GetScore();
            Destroy(this.gameObject);
            Destroy(collision.collider.gameObject);
        }
    }
}
