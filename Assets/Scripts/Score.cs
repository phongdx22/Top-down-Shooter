using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int score;

    public void AddScore(int amount)
    {
        score += amount;
    }
}
