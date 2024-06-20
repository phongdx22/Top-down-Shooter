using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBarUI : MonoBehaviour
{
    public Image healthBarBackground;
    public Image healthBarFill;
    public Transform enemy;
    public Vector3 offset;

    Health health;

    void Start()
    {
        health = enemy.GetComponent<Health>();

        UpdateHealthBar();
    }

    void Update()
    {
        UpdatePosition();
        UpdateHealthBar();
    }

    void UpdatePosition()
    {
        Vector3 worldPosition = enemy.position + offset;
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(worldPosition);

        transform.position = screenPosition;
    }

    void UpdateHealthBar()
    {
        healthBarFill.fillAmount = health.healthPercentage;
    }
}
