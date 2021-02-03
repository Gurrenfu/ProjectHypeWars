
using UnityEngine;

public class SpawnableObject: MonoBehaviour
{
    public float spawnProbability;
    private ObjectSpawnPoint spawnPoint;
    private ObjectSpawner objSpawner; 

    public void SetSpawnPoint(ObjectSpawnPoint spawn)
    {
        spawnPoint = spawn;
    }

    public ObjectSpawnPoint GetSpawnPoint()
    {
        return spawnPoint;
    }

    public void SetSpawner(ObjectSpawner spawner)
    {
        objSpawner = spawner;
    }

    private void OnDisable()
    {
        objSpawner.Remove(this);
    }
}
    

