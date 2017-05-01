using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject Enemy;
    private Vector3 SpawnPoint;
    private int SpawnAmount = 5;
    private int i = 0;
    private bool spawning = true;
    private int wave = 1;

    [SerializeField]
    private GameObject Player;
    public int mapSize = 25;
    private int random;
    private int randomX;
    private int randomY;

    public Text waveText;

    public void spawner()
    {
        waveText.text = "wave: " + wave;
        for (int j = 0; j < SpawnAmount; j++)
        {
            if (i <= SpawnAmount)
            {
                SpawnPoint.x = Random.Range(-mapSize, mapSize);
                SpawnPoint.z = Random.Range(-mapSize, mapSize);
                SpawnPoint.y = 0;
                Instantiate(Enemy, SpawnPoint, transform.rotation);
            }
        }
        SpawnAmount += 3;
        i = 0;
        wave += 1;
    }
}
