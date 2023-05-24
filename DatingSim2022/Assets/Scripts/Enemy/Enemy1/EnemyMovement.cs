using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rb2;
    public float speed;
    public float direction;

    private void Start()
    {
        player = GameObject.Find("Players");
    }

    private void Update()
    {
        if (player.transform.position.x > transform.position.x)
        {
            direction = 1;
        }
        else
        {
            direction = -1;
        }
    }

    private void FixedUpdate()
    {
        rb2.velocity = new Vector2(direction * speed, rb2.velocity.y);
    }
}
