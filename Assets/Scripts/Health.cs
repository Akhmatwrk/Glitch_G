﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100;

    public void DealDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destraction();
        }
    }

    private void Destraction()
    {
        Destroy(gameObject);
    }
}
