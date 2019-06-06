using UnityEngine;

public class Character_Warrior : MonoBehaviour
{
    //W = warrior
    [SerializeField] private LayerMask W_WhatIsGround;
    [SerializeField] private float W_MaxSpeed = 10.0f;
    [SerializeField] private float W_JumpForce = 400.0f;

    private Animator W_Anim;                 //animator component 
    private Rigidbody2D W_Rigidbody2D;  
    private bool W_Grounded;                 //Warrior is grounded or not.
    private Transform W_GroundCheck;
    private Transform W_CeilingCheck;
    const float CeilingRadius = 0.01f;       //Radius of the overlap circle to determine if the player can stand up       
    const float GroundedRadius = 0.2f;       //Radius of the overlap circle to determine if grounded          
    private bool W_FacingRight = true;       //currently facing

    private void Awake()
    {
        W_CeilingCheck = transform.Find("CeilingCheck");
        W_GroundCheck = transform.Find("GroundCheck");
        W_Anim = GetComponent<Animator>();
        W_Rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        W_Grounded = false;
        Collider2D[] colliders = Physics2D.OverlapCircleAll(W_GroundCheck.position, GroundedRadius, W_WhatIsGround);
        for(int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject)
                W_Grounded = true;
        }
        W_Anim.SetBool("Ground", W_Grounded);
    }

    public void Move(float move, bool jump, bool attack, bool shield)
    {
        if(W_Grounded)
        {
            W_Anim.SetFloat("Speed", Mathf.Abs(move));
            W_Rigidbody2D.velocity = new Vector2(move * W_MaxSpeed, W_Rigidbody2D.velocity.y);
        }
    }

    private void Flip()
    {
        //Switch facing direction
        W_FacingRight = !W_FacingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}