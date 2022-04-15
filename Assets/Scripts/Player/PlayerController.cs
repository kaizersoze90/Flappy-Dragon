using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float dieReloadDelay = 2f;

    Rigidbody2D _rigidbody2D;
    Fly _fly;
    Die _die;
    bool _isJumpKeyDown;

    void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _fly = GetComponent<Fly>();
        _die = GetComponent<Die>();
    }

    void FixedUpdate()
    {
        if (_isJumpKeyDown)
        {
            _fly.ProcessFly(_rigidbody2D);
            _isJumpKeyDown = false;
        }
    }

    void OnFly(InputValue button)
    {
        if (button.isPressed)
        {
            _isJumpKeyDown = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        _die.ProcessDie();
        GameManager.Instance.RestartGame(dieReloadDelay);
    }
}
