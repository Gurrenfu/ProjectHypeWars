using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner: MonoBehaviour
{
    //possible items to spawn
    [SerializeField]private SpawnableObject[] spawnableObjects;
    //possible places to spawn objects
    [SerializeField]private ObjectSpawnPoint[] spawnPoints;

    //items that have been enabled in the scene
    private  List<SpawnableObject> activeItems = new List<SpawnableObject>();
    

    public int GetNumberOfSpawnPoints()
    {
        return spawnPoints.Length;
    }

    public SpawnableObject GetSpawnObject()
    {
        //TODO add in probability weights
        int objectIndex = Random.Range(0, spawnableObjects.Length);
        return spawnableObjects[objectIndex];
    }

    public ObjectSpawnPoint GetSpawnPoint()
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
        spawnPoints[pointIndex].SetUnavailable();
        isAvailable = false;
        return spawnPoints[pointIndex];
    }

    public void SpawnObject(SpawnableObject item, ObjectSpawnPoint spawnPoint)
    {
        SpawnableObject newObj = Instantiate(item, spawnPoint.GetPosition(), Quaternion.identity);
        activeItems.Add(newObj);
        newObj.SetSpawnPoint(spawnPoint);
        newObj.SetSpawner(this);
    }


    public void Remove(SpawnableObject oldItem)
    {
        if(oldItem != null && !isQuitting)
        {
            activeItems.Remove(oldItem);
            oldItem.GetSpawnPoint().SetAvailable();
            Debug.Log("removed");
            SpawnObject(GetSpawnObject(), GetSpawnPoint());
        }
       
    }

    //called before ondestory to prevent items from spawning after the game has closed. 
    bool isQuitting = false;
    void OnApplicationQuit()
    {
        isQuitting = true;
    }

}
