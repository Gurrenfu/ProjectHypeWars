using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCombat : MonoBehaviour
{
    //player weapon info
    public Animator animator;
    public Transform firePoint;
    public Transform aimPivot;
    public GameObject bulletPrefab;
    public GameObject crossHair;
    private Camera mainCamera;
    private float projectileAimAngle;
    private Vector2 aimVector;
    private bool lookingRight = true;

    public Transform swingPoint;
    public float swingRange;
    public LayerMask targets;
    public int swingDamage = 20;


    private void Start()
    {
        mainCamera = Camera.main;
        Cursor.visible = false;
    }

    public void Shoot(InputAction.CallbackContext value)
    {
        if(value.started)
        {
            animator.SetBool("isShooting", true);
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            StartCoroutine(StopShooting());
        }
       
    }

    private IEnumerator StopShooting()
    {
        yield return new WaitForSeconds(.25f);
        animator.SetBool("isShooting", false);
    }

    public void SimpleMelee(InputAction.CallbackContext Value)
    {
        if(Value.started)
        {
            animator.SetBool("isSwinging", true);
            Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(swingPoint.position, swingRange, targets);
            for (int i = 0; i < enemiesToDamage.Length; i++)
            {
                IDamageable damageableObject = enemiesToDamage[i].GetComponent<IDamageable>();
                if (damageableObject != null)
                {
                    damageableObject.TakeDamage(swingDamage);
       
                }
            }
        }
        StartCoroutine(StopSwinging());
    }


    private IEnumerator StopSwinging()
    {
        yield return new WaitForSeconds(.25f);
        animator.SetBool("isSwinging", false);
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(swingPoint.position, swingRange);
    }



    public void GamepadMoveCrosshair(InputAction.CallbackContext value)
    {
        aimVector = value.ReadValue<Vector2>();
        Flip(aimVector);
        aim(aimVector);
        
    }

    public void MouseMoveCrosshair(InputAction.CallbackContext value)
    {
        aimVector = value.ReadValue<Vector2>();
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(aimVector);
        Vector3 targetDirection = mouseWorldPosition - transform.position;
        aim(targetDirection);
        Flip(targetDirection);
    }

    private void aim(Vector2 aimVector)
    {
        projectileAimAngle = Mathf.Atan2(aimVector.y, aimVector.x) * Mathf.Rad2Deg;
        aimPivot.rotation = Quaternion.Euler(new Vector3(0f, 0f, projectileAimAngle));
    }

    private void Flip(Vector2 aimVector)
    {//can't aim straight up or down
        if ((aimVector.x < 0 && lookingRight) | (aimVector.x > 0 && !lookingRight)) 
        {
            lookingRight = !lookingRight;
            transform.Rotate(0f, 180f, 0f);

        }

    }
}

