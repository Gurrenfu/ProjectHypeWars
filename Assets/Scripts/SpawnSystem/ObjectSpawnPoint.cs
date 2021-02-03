using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawnPoint : MonoBehaviour
{
    private bool available = true;

    public Vector2 GetPosition()
    {
        return gameObject.transform.position;
    }
    public bool GetAvailability()
    {
        return available;
    }

    public void SetAvailable()
    {
        available = true;
    }

    public void SetUnavailable()
    {
        available = false;
    }
}
