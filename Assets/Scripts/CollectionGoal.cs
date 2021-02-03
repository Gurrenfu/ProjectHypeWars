using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionGoal : MonoBehaviour
{
    //game score table 
    //move function 
    private void OnTriggerStay(Collider other)
    {
        PlayerManager playerManager = other.GetComponent<PlayerManager>();
        if(playerManager != null)
        {
           int aFilerVariable = playerManager.playerStats.Score;
           //put into game score table
           //remove carrying score from player
           //keep track of how many total points they get over the game;
        }
    }
}
