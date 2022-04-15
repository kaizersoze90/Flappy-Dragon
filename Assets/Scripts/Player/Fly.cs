using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    [SerializeField] float jumpForce = 5f;
    [SerializeField] AudioClip[] struggleSFX;

    public void ProcessFly(Rigidbody2D rigidbody2D)
    {
        FlyAction(rigidbody2D);
        PlayStruggleSFX();
    }

    void FlyAction(Rigidbody2D rigidbody2D)
    {
        rigidbody2D.velocity = Vector2.zero;
        rigidbody2D.AddForce(Vector2.up * jumpForce);
    }

    void PlayStruggleSFX()
    {
        AudioSource.PlayClipAtPoint(struggleSFX[Random.Range(0, 3)], Camera.main.transform.position);
    }
}
