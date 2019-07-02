using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RhythmAssets;

public class Weapon_Shield : MonoBehaviour
{
    //[SerializeField] ParticleSystem DefenceEffect;
    private Character_Warrior Warrior_Ref;

    // Start is called before the first frame update
    void Awake()
    {
        Warrior_Ref = GetComponentInParent<Character_Warrior>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Arrow")
        {
            Warrior_Ref.Rhythm_GM.Score += 10; 
            Destroy(other.gameObject);
            Debug.Log(Warrior_Ref.Rhythm_GM.Score);
            /*
            DefenceEffect.Stop();
            DefenceEffect.Play();
            Destroy(other.gameObject);
            */

        }
    }
}
