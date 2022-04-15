using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People : MonoBehaviour
{
    [SerializeField] float runSpeed = 7f;
    [SerializeField] float lifeTime = 5f;

    float _currentTime;

    void Update()
    {
        _currentTime += Time.deltaTime;
        if (_currentTime > lifeTime)
        {
            Destroy();
        }

        Run();
    }

    void Run()
    {
        Vector3 _direction = Vector3.left * runSpeed * Time.deltaTime;
        transform.Translate(_direction);
    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}
