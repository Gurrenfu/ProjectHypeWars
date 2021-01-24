using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointObject : MonoBehaviour
{
    public int value = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<IPlayerService>().playerStats.ChangeScoreByValue(value);
        Debug.Log("point added");
        //Consider changin the destroy to disable; 
        Destroy(gameObject);
    }

    //enable function
    //ondisale talk to spawner to notify;
}
