using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float bulletSpeed;
    PlayerMovement player;
    Rigidbody2D rb;
    float xSpeed;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Health health = collision.gameObject.GetComponent<Health>();
            health.ReduceHealth(10);
            Destroy(gameObject);
        }
        if (collision.tag == "Wall")
            Destroy(gameObject);


    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.GetMask("Wall"))
        {
            Destroy(gameObject);
        }
    }
}
