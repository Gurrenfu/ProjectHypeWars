using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

public class ReassignControllers : MonoBehaviour
{

    public GameObject player1;
    public GameObject player2;

 
    public float lifeSpan = 10;
    bool started = false;


    // Update is called once per frame
    private void Update()
    {
        lifeSpan -= Time.deltaTime;
        if (lifeSpan <= 0 && !started)
        {    started = true;
            Reassign();
        }

    }


    void Reassign()
    {
        Debug.Log("reassign");

        player2.GetComponent<PlayerController>().AssignInput(player1.GetComponent<PlayerController>().pi);
    }
}

