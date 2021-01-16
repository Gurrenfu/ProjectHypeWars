using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu]
public class MultiPlayerManager : ScriptableObject
{

    private int numberOfPlayers = 1;
    public GameObject playerPrefab;
    [HideInInspector] public List<PlayerStats> playerStatsList;
    private List<PlayerConfiguration> playerConfigsList;

    /// <summary>
    /// New game setup. Make the new tables
    /// </summary>
    public void SetupNewManager()
    {
        createPlayerConfigsList();
        createPlayerStatsList();
        Debug.Log("setup");
    }

    public void createPlayerConfigsList()
    {
        playerConfigsList = new List<PlayerConfiguration>();
    }

    public void createPlayerStatsList()
    {
        playerStatsList = new List<PlayerStats>();
    }

    /// <summary>
    /// Invoke from InputManager
    /// </summary>
    /// <param name="pi"></param>
    public void HandlePlayerJoin(PlayerInput pi)
    {
        Debug.Log("Player joined: " + pi.playerIndex);
        if (!playerConfigsList.Any(p => p.PlayerIndex == pi.playerIndex))
        {
            playerConfigsList.Add(new PlayerConfiguration(pi));
            PlayerStats playerStatsInstance = new PlayerStats();
            playerStatsList.Insert(pi.playerIndex, playerStatsInstance);
            pi.GetComponent<PlayerManager>().playerStats = playerStatsInstance;
            pi.GetComponent<PlayerManager>().setDefaultValues();
            numberOfPlayers++;
        }
    }
    public void changeNumberOfPlayers(int number)
    {
        Debug.Log("new list made 2");
        numberOfPlayers += number;
    }



    /// <summary>
    /// get functions
    /// </summary>
    /// <returns></returns>
    public List<PlayerConfiguration> GetPlayerConfigsList()
    {
        return playerConfigsList;
    }



    /// <summary>
    /// testers
    /// </summary>
    /// <param name="index"></param>
    public void ReadyPlayer(int index)
    {
        playerConfigsList[index].isReady = true;
        if (playerConfigsList.All(p => p.isReady == true))
        {
           // SceneManager.LoadScene("TestScene");
        }
    }

    /// <summary>
    /// TODO move to game manager;
    /// </summary>
    public void SpawnPlayers()
    {
        for (int p = 0; p < numberOfPlayers; p++)
        {
            //if playersstats is SO use this
           
            //if playerstats is a plain C# script use this
            //PlayerStats playerStatsInstance = new PlayerStats();

            GameObject newPlayer = Instantiate(playerPrefab, new Vector3(4f, 0.3f, 0), Quaternion.identity);
            //newPlayer.GetComponent<APlayerService>().playerStats = playerStatsInstance;
            //playerStatsList.Add(playerStatsInstance);
        }
        Debug.Log("From Manager the  count: " + playerStatsList.Count+ "\n");
    }

}

