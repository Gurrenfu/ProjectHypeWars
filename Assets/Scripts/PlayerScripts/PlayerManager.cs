using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour, IPlayerService,  IDamageable
{
    public int health;
    private int fullHealth;
    public PlayerStats playerStats { get; set; }
    [SerializeField] private SpawnPointRTS respawnPoints;
    
    void Awake()
    {
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
        gameObject.transform.position = respawnPoints.getSpawnPoint();
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