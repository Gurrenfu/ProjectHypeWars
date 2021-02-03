using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawner : MonoBehaviour
{
    [SerializeField] private ObjectSpawnPoint[] spawnPoints;
    // Start is called before the first frame update

    
    public int GetNumberOfSpawnPoints()
    {
        return spawnPoints.Length;
    }

    public Vector2 GetSpawnPointPosition()
    {
        int pointIndex = 0;
        bool isAvailable = false;

        //loop through points until available one is found
        do
        {
            pointIndex = Random.Range(0, spawnPoints.Length);
            isAvailable = spawnPoints[pointIndex].GetAvailability();

        } while (isAvailable == false);

        //set the chosen spawn to unvailable, reset tracker varaible 
       // spawnPoints[pointIndex].SetUnavailable();
        isAvailable = false;
        return spawnPoints[pointIndex].GetPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
