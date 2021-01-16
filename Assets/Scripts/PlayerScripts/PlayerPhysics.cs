using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerPhysics
{ 
    private Rigidbody2D rb;
    public float fallMultiplier = 2.5f;
    

    public void SetRigidBody(Rigidbody2D rigidBody)
    {
        rb = rigidBody;
    }


    public void updatePlayerPhysics()
    {
        if (rb.velocity.y<0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
    }
}
