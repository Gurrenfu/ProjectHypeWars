using UnityEngine;

[CreateAssetMenu]
public class RespawnPointRTS : RunTimeSet<RespawnPoint>
{
    //inherieted set(Items) of respawn points

   public Vector3 getRespawnPoint()
    {
        int pointIndex = Random.Range(0, Items.Count);
        RespawnPoint respawnPoint = Items[pointIndex];
        return respawnPoint.transform.position;
    }

}
    

