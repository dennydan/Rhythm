using UnityEngine;

public class Character_Warrior : MonoBehaviour
{
    [SerializeField] private LayerMask m_WhatIsGround;
    [SerializeField] private float Warrior_MaxSpeed = 10.0f;
    [SerializeField] private float Warrior_JumpForce = 400.0f;
    private Animator Warrior_Anim;
    private Rigidbody2D Warrior_Rigidbody2D;
    private bool m_Grounded;
    private void Awake()
    {
        Warrior_Anim = GetComponent<Animator>();
        Warrior_Anim.SetBool("Shield", true);
        Warrior_Rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        m_Grounded = false;
    }
    // Start is called before the first frame update

    // Update is called once per frame
}