using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemyCounter : MonoBehaviour 
{
    private int Enemyleft;
    private EnemySpawner EnemySpawner;

    void Awake ()
    {
        EnemySpawner = GetComponent<EnemySpawner>();
    }
    void Update ()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        Enemyleft = enemies.Length;
        if (Enemyleft == 0)
        {            
            EnemySpawner.spawner();
        }
    }
}
