using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] List<GameObject> SpawnPoints = new List<GameObject>();
    [SerializeField] int MaxEnemies = 10;
    [SerializeField] List<GameObject> EnemyPrefab = new List<GameObject>();
    [SerializeField] int eAmount = 0;

    bool _o = false;

    void Start()
    {

    }
    void Update()
    {
        eAmount = GameSystem.enemyAmount;
        if (GameSystem.enemyAmount < MaxEnemies)
        {
            int spawn = Random.Range(0, SpawnPoints.Count);
            Debug.Log(spawn);
            Instantiate(EnemyPrefab[Random.Range(0, EnemyPrefab.Count)], SpawnPoints[spawn].transform.position + new Vector3(Random.Range(-3, 3), Random.Range(-3, 3), 0), Quaternion.identity);
        }
        if (GameSystem.GameOver && !_o)
        {
            _o = true;
            Debug.Log("Game Over");
        }
    }
}
