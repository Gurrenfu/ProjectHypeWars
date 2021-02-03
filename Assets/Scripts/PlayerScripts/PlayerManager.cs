using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour, IPlayerService,  IDamageable
{
    public int health;
    private int fullHealth;
    private PlayerRespawner playerRespawner;
    public PlayerStats playerStats { get; set; }
    
    void Awake()
    {
       playerRespawner = FindObjectOfType<PlayerRespawner>();
       fullHealth = health;
    }
   
    public void setDefaultValues()
    {
        playerStats.Player = gameObject;
        playerStats.Health = health;
    }

    public void Respawn()
    {
        playerStats.Health = fullHealth;
        gameObject.transform.position = playerRespawner.GetSpawnPointPosition();
    }

   
    ///IDamageable=============
    public void TakeDamage(int damage)
    {
        playerStats.ChangeHealthByValue(-damage);
        if (playerStats.Health <= 0)
        {
            playerStats.ChangeDeathsByValue(1);
            Respawn();
        }
           
    }
   
}