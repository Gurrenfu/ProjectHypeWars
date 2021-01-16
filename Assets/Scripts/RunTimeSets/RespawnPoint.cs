using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    public RespawnPointRTS RunTimeSet;

    private void OnEnable()
    {
        RunTimeSet.Add(this);
    }

    private void OnDisable()
    {
        RunTimeSet.Remove(this);
    }

}

