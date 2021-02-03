using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISpawnPoint
{
    Vector2 GetPosition();
    void SetAvailable();
    void SetUnavailable();
}
