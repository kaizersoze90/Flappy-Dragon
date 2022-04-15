using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject[] enemyPrefabs;
    [SerializeField] float maxYBoundary, minYBoundary;
    [SerializeField][Range(1f, 5f)] float maxTimeBetweenSpawn;
    [SerializeField][Range(0.5f, 2.5f)] float minTimeBetweenSpawn;

    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    void Update()
    {
        GetFasterSpawnsInTime();
    }

    void GetFasterSpawnsInTime()
    {
        maxTimeBetweenSpawn -= Time.deltaTime / 100;
        minTimeBetweenSpawn -= Time.deltaTime / 100;

        maxTimeBetweenSpawn = Mathf.Clamp(maxTimeBetweenSpawn, 1f, float.MaxValue);
        minTimeBetweenSpawn = Mathf.Clamp(minTimeBetweenSpawn, 0.5f, float.MaxValue);
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            for (int i = 0; i < enemyPrefabs.Length; i++)
            {
                int enemyIndex = Random.Range(0, enemyPrefabs.Length);

                CreateEnemy(enemyPrefabs[enemyIndex]);
                yield return new WaitForSeconds(Random.Range(minTimeBetweenSpawn, maxTimeBetweenSpawn));
            }
        }
    }

    void CreateEnemy(GameObject enemy)
    {
        float randomYBoundary = Random.Range(minYBoundary, maxYBoundary);
        Vector3 pos = new Vector3(transform.position.x, randomYBoundary, transform.position.z);

        Instantiate(enemy, pos, Quaternion.identity, transform);
    }
}
