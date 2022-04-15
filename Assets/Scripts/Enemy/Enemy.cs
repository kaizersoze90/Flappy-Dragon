using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int myScore = 10;

    public int GetScore { get { return myScore; } }
}
