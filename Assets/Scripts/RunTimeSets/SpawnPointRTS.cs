using UnityEngine;

[CreateAssetMenu]
public class SpawnPointRTS : RunTimeSet<SpawnPoint>
{
    //inherieted set(Items) of respawn points

   public Vector3 getSpawnPoint()
    {
        int pointIndex = Random.Range(0, Items.Count);
        SpawnPoint spawnPoint = Items[pointIndex];
        return spawnPoint.transform.position;
    }

}
    

