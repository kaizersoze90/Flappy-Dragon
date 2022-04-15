using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFly : MonoBehaviour
{
    [SerializeField] float maxFlySpeed = 7f;
    [SerializeField] float minFlySpeed = 3f;

    float _flySpeed;

    void Start()
    {
        _flySpeed = Random.Range(minFlySpeed, maxFlySpeed);
    }

    void Update()
    {
        Vector3 _direction = Vector3.left * _flySpeed * Time.deltaTime;
        transform.Translate(_direction);
    }
}
