using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class PlayerLocomotion : MonoBehaviour
    {
    //comoponent references
    public PlayerController controller;
    public Animator animator;
   
    [SerializeField] private float speed = 40f;
    [Range(0, 1)] [SerializeField] private float crouchSpeed = .36f;          // Amount of maxSpeed applied to crouching movement. 1 = 100%
    [Range(0, .3f)] [SerializeField] private float movementSmoothing = .05f;  // How much to smooth out the movement
    [SerializeField] private float jumpForce = 4f;
    [Range(0, 4)] [SerializeField] private int jumpCount = 2;
    [SerializeField] private float fallMultiplier = 2.5f;

    //hierarchy components
    private Rigidbody2D m_rigidbody2D;
    [SerializeField] private Collider2D crouchDisableCollider;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private Transform ceilingCheck;
    [SerializeField] private LayerMask groundLayer;
    
    //internal values
    private Vector3 zeroVelocity = Vector3.zero; //zero vector for smooth damping
    private int speedScalar = 10;
    const float k_GroundedRadius = .2f; // Radius of the overlap circle to determine if grounded
    private bool grounded;            // Whether or not the player is grounded.
    const float k_CeilingRadius = .2f; // Radius of the overlap circle to determine if the player can stand up
    private bool wasCrouching = false;
    private int remainingJumps; //current jumps the player has;
    
    //=======================
    //create events
    [Header("Events")]
    [Space]
    public UnityEvent OnLandEvent;
    [System.Serializable]
    public class BoolEvent : UnityEvent<bool> { }
    public BoolEvent OnCrouchEvent;

    //player in game state variables
    private bool crouch = false;
    
    private float movementValue;
 
    //======================
    private void Awake()
    {
        m_rigidbody2D = GetComponent<Rigidbody2D>();
        if (OnLandEvent == null)
            OnLandEvent = new UnityEvent();

        if (OnCrouchEvent == null)
            OnCrouchEvent = new BoolEvent();
    }


    public void Crouch(InputAction.CallbackContext value)
    {
        if (value.performed)
        {
            crouch = true;
        }
        else if (value.canceled)
        {
            crouch = false;
        }
    }

    public void Move(InputAction.CallbackContext value)
    {
        movementValue = value.ReadValue<float>();
    }
    

    public void Jump(InputAction.CallbackContext value)
    {
        
        if (remainingJumps > 0 )
        {
         
            animator.SetBool("isJumping", true);
            //send jump vector to player controller to apply
            //m_rigidbody2D.AddForce(Vector2.up* jumpForce,ForceMode2D.Impulse);
            m_rigidbody2D.velocity = Vector2.up* jumpForce;
            grounded = false;
            remainingJumps--;
        }
    }

   

    void PerformMove(float movementValue, bool crouching)
    {
        // If crouching, check to see if the character can stand up
        if (!crouching)
        {
            // If the character has a ceiling preventing them from standing up, keep them crouching
            if (Physics2D.OverlapCircle(ceilingCheck.position, k_CeilingRadius, groundLayer))
            {
                crouching = true;
            }
        }

        // If crouching
        if (crouching)
        {
            if (!wasCrouching)
            {
                wasCrouching = true;
                OnCrouchEvent.Invoke(true);
            }

            // Reduce the speed by the crouchSpeed multiplier
            movementValue *= crouchSpeed;

            // Disable one of the colliders when crouching
            if (crouchDisableCollider != null)
                crouchDisableCollider.enabled = false;
        }
        else
        {
            // Enable the collider when not crouching
            if (crouchDisableCollider != null)
                crouchDisableCollider.enabled = true;

            if (wasCrouching)
            {
                wasCrouching = false;
                OnCrouchEvent.Invoke(false);
            }
        }

        // Move the character by finding the target velocity and smooth it
        Vector3 targetVelocity = new Vector2(movementValue * speed * speedScalar * Time.deltaTime, m_rigidbody2D.velocity.y);
        m_rigidbody2D.velocity = Vector3.SmoothDamp(m_rigidbody2D.velocity, targetVelocity, ref zeroVelocity, movementSmoothing);
    }

    public void OnLanding()
    {
        animator.SetBool("isJumping", false);
    }

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("isCrouching", isCrouching);
    }

    void Update()
    {
        animator.SetFloat("speed", Mathf.Abs(movementValue));
    }

    private void FixedUpdate()
    {
        PerformMove(movementValue, crouch);
        bool wasGrounded = grounded;
        grounded = false;
        
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheck.position, k_GroundedRadius, groundLayer);
        for (int i = 0; i < colliders.Length; i++)
        {
            if ((colliders[i].gameObject != gameObject))
            {

                grounded = true;
                remainingJumps = jumpCount;
                if (!wasGrounded)
                    OnLandEvent.Invoke();
            }
        }
        //maybe move within a jump script to only call upon jumping aciton
        if (m_rigidbody2D.velocity.y < 0)
        {
            m_rigidbody2D.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
    }
}
