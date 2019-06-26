using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RhythmAssets;

public class Player_Controller : MonoBehaviour
{
    [SerializeField] Character_Warrior CharacterReference;
    [SerializeField] Rigidbody2D CharacterRig;
    [SerializeField] Rhythm_GameMode rhythm_GameMode;
    
    // Start is called before the first frame update
    void Start()
    {
        CharacterRig.centerOfMass = Vector3.zero;
    }
    float speed = 0.0f;
    bool isAttack = false;
    bool isShield = false;
    bool isJump = false;

    // Update is called once per frame
    void Update()
    {

        isJump = Input.GetKeyDown(KeyCode.Space); 
        isAttack = Input.GetMouseButtonDown(0);
        isShield = Input.GetMouseButtonDown(1);
        if(isAttack || isShield)
        {
            speed = Mathf.Lerp(speed, 0.0f, 0.01f);
        }
        else
        {
            speed = Mathf.Lerp(speed, 1.0f, 0.01f);
        }
       
        CharacterReference.Move(speed, isJump, isAttack, isShield);
        isJump = false;
    }
}
