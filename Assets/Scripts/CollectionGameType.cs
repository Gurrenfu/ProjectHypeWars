using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionGameType : MonoBehaviour
{
    //score goal
    //time

    //item spawning
    public ObjectSpawner pointObjectSpawner;
    public int initialObjectsMin;
    public int initialObjectsMax;
    private int numberOfSpawnPoints;
  
    private void Awake()
    {
        numberOfSpawnPoints = pointObjectSpawner.GetNumberOfSpawnPoints();
        if (numberOfSpawnPoints < initialObjectsMax || initialObjectsMin > initialObjectsMax)
        {
            Debug.LogWarning("Check intitial object spawn amounts");
        }
        else
        {
            OnAwakeItemSpawn();
        }
    }

 
    private void OnAwakeItemSpawn()
    {
        int initialSpawnCount= Random.Range(initialObjectsMin, initialObjectsMax);

        for (int i = 0; i < initialSpawnCount; i++)
        {
            SpawnableObject selectedObject = pointObjectSpawner.GetSpawnObject();
            ObjectSpawnPoint selectedSpawnPoint = pointObjectSpawner.GetSpawnPoint();
            pointObjectSpawner.SpawnObject(selectedObject, selectedSpawnPoint);
        }
    }
}
