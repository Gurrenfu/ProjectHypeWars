using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerStats 

{
    [SerializeField] private GameObject _player;
    [SerializeField] private int _health = 0;
    [SerializeField] private int _score = 0;
    [SerializeField] private int _killCount = 0;
    [SerializeField] private int _deathCount  = 0;


    /// <summary>
    /// get and set values of properties
    /// </summary>
    /// 
    public GameObject Player
    {
        get => _player;
        set => _player = value;
    }
    public int Health
    {
        get => _health;
        set => _health = value;
    }
    public int Score
    {
        get => _score;
        set => _score = value;
    }
    public int Kills
    {
        get => _killCount;
        set => _killCount = value;
    }
    public int Deaths
    {
        get => _deathCount;
        set => _deathCount = value;
    }

    

    /// <summary>
    /// change fields by value
    /// </summary>
    public void ChangeHealthByValue(int value)
    {
        _health += value;
    }
    public void ChangeScoreByValue(int value)
    {
         _score += value;
    }
    public void ChangeKillsByValue(int value)
    {
        _killCount += value;
    }
    public void ChangeDeathsByValue(int value)
    {
        _deathCount += value;
    }

}

