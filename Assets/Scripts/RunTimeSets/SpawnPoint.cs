using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public SpawnPointRTS RunTimeSet;

    private void OnEnable()
    {
        RunTimeSet.Add(this);
    }

    private void OnDisable()
    {
        RunTimeSet.Remove(this);
    }

}

