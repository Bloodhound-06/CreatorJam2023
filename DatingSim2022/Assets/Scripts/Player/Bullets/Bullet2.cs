using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public GameObject player;
    public float damage = 20;
    public float splashRange = 20;
    private void Start()
    {
        player = GameObject.Find("Players");
        if (player.transform.rotation.y == 0)
        {
            rb.AddForce(speed * new Vector2(1, 1), ForceMode2D.Impulse);
        }
        else
        {
            rb.AddForce(speed * new Vector2(-1, 1), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (splashRange > 0)
        {
            var hitColliders = Physics2D.OverlapCircleAll(transform.position, splashRange);
            foreach (var hitCollider in hitColliders)
            {
                var enemy = hitCollider.GetComponent<Enemy1Health>();
                if (enemy)
                {
                    var closestPoint = hitCollider.ClosestPoint(transform.position);
                    var distance = Vector3.Distance(closestPoint, transform.position);

                    var damagePercent = Mathf.InverseLerp(splashRange, 0, distance);
                    enemy.Enemy1Damage(damagePercent * damage);
                }
            }
        }
        Destroy(gameObject);
    }
}
