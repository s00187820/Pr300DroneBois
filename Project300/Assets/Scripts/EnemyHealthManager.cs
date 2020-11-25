﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    public int health;
    private int currentHealth;

    void Start()
    {
        currentHealth = health;
    }

    
    void Update()
    {
        if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void DamageEnemy(int damage)
    {
        currentHealth -= damage;
    }
}
