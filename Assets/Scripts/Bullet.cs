using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 20;
    public int numberOfBounces = 3;
    public float lifeSpan = 3;
    public Rigidbody2D rb;
    
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void Update()
    {
        lifeSpan -= Time.deltaTime;
        if(lifeSpan<=0)
        {
            Destroy(gameObject);
        }

    }

    private void OnCollisionEnter2D (Collision2D hitInfo)
    {
        //Debug.Log(hitInfo.gameObject.name);
        IDamageable damageableObject = hitInfo.gameObject.GetComponent<IDamageable>();
        if (damageableObject != null)
        {
            damageableObject.TakeDamage(damage);
            Destroy(gameObject);
        }
        else
        {
            Vector2 objectNormalVector = hitInfo.contacts[0].normal;
            Vector2 reflectVector = Vector2.Reflect(rb.velocity, objectNormalVector).normalized;
            rb.velocity = reflectVector * speed;
            --numberOfBounces;
            if(numberOfBounces <= 0)
            {
                Destroy(gameObject);
            }
        }

    }
}
