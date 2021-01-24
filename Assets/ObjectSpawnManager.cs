using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawnManager : MonoBehaviour
{
    public List<GameObject> pointObjSpawnPoints = new List<GameObject>();
    private List<Vector2> pointObjSpawnPointsPos;
    public GameObject pointObj;

    private void Awake()
    {
        pointObjSpawnPointsPos = new List<Vector2>();
        foreach (GameObject point in pointObjSpawnPoints)
        {
            pointObjSpawnPointsPos.Add(point.transform.position);
        }    
    }

    public void GetRandomPoint()
    {

    }
    //getrandompoint
    //settoAvailable
    //spawnObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
}
