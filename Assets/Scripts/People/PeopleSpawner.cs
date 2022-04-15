using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleSpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> peoplePrefabs;
    [SerializeField] float delayBetweenSpawn = 10f;

    void Start()
    {
        StartCoroutine(SpawnPeople());
    }

    IEnumerator SpawnPeople()
    {
        yield return new WaitForSeconds(10f);

        while (true)
        {
            foreach (GameObject people in peoplePrefabs)
            {
                CreateEnemy(people);
                yield return new WaitForSeconds(delayBetweenSpawn);
            }
        }
    }

    void CreateEnemy(GameObject people)
    {
        Instantiate(people, transform.position, Quaternion.identity, transform);
    }
}
