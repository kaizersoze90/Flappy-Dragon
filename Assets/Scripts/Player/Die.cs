using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    [SerializeField] GameObject explosionPrefab;

    public void ProcessDie()
    {
        GameObject explosionGO = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(explosionGO, 0.833f);
        Destroy(gameObject);
    }
}
