using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{
    public float BulletSpeed = 10;
    public Rigidbody2D rb;
    private void Start()
    {
        rb.AddForce(transform.up * BulletSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Enemy1Health>().Enemy1Damage(10);
        }

        Destroy(gameObject);
    }
}
