using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    public int health = 40;

    // Update is called once per frame
   public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
           Destroy(gameObject);
        }
    }
}
