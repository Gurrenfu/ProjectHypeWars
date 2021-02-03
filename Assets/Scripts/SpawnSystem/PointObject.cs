using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointObject : MonoBehaviour
{ 
    [SerializeField]private int value = 1;
    private bool active = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (active)
        {
            active = false;
            collision.gameObject.GetComponent<IPlayerService>().playerStats.ChangeScoreByValue(value);
            Destroy(gameObject);
            Debug.Log("point added");
        }
    }
}
