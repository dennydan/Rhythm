using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RhythmAssets;

public class Player_Controller : MonoBehaviour
{
    [SerializeField] Character_Warrior Warrior_Ref;
    [SerializeField] Rigidbody2D CharacterRig;
    [SerializeField] Rhythm_GameMode rhythm_GameMode;
    [SerializeField] Weapon_Ax Weapon_Ref;
    
    // Start is called before the first frame update
    void Awake()
    {
    }

    void Start()
    {
        CharacterRig.centerOfMass = Vector3.zero;           //Set Center of gravity
    }
    float speed = 0.0f;
    bool isAttack = false;
    bool isShield = false;
    bool isJump = false;

    // Update is called once per frame
    void Update()
    {
        playerControll();
    }

    private void playerControll()
    {
        isJump = Input.GetKeyDown(KeyCode.Space);
        isAttack = Input.GetButtonDown("Fire2");
        isShield = Input.GetButtonDown("Fire3");
        if (isAttack || isShield)
        {
            speed = Mathf.Lerp(speed, 0.0f, 0.01f);
        }
        else
        {
            speed = Mathf.Lerp(speed, 1.0f, 0.01f);
        }

        if (Input.GetButtonDown("Fire1") && !Warrior_Ref.CharacterDie)
        {
            Weapon_Ref.Shoot_Bullet();                          //Shoot
        }

        Warrior_Ref.Move(speed, isJump, isAttack, isShield);    //Controlling of Character's motion 
        isJump = false;
    }
}
