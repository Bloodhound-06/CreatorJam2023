using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Health : MonoBehaviour
{
    public float enemy1Health;  
    public float enemy1MaxHealth;

    private void Start()
    {
        enemy1Health = enemy1MaxHealth;
    }

    public void Enemy1Damage(float value)
    {
        enemy1Health -= value;

        if(enemy1Health <= 1)
        {
            Destroy(gameObject);
        }
    }
}
