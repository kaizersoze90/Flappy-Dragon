using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] AudioClip countSFX;

    int _score;

    void Update()
    {
        scoreText.text = _score.ToString("00000");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Enemy enemy = other.GetComponent<Enemy>();

        if (enemy != null)
        {
            _score += enemy.GetScore;
            PlayCountSFX();
        }
    }

    void PlayCountSFX()
    {
        AudioSource.PlayClipAtPoint(countSFX, Camera.main.transform.position, 1f);
    }

}
