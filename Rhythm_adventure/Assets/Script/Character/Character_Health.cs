using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RhythmAssets;

public class Character_Health : MonoBehaviour
{
//    [SerializeField] private float Health = 1.0f;
    [SerializeField] Slider healthSlider;
    [SerializeField] Image beHitImage;
    [SerializeField] private float bDamage = 0.1f;
    [SerializeField] private Character_Warrior Character_Ref;
    [SerializeField] private Animator CharactorAnim_ref;
    // Start is called before the first frame update

    void Start()
    {
        healthSlider.value = Character_Ref.Health;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Arrow" || other.tag == "Obstacle" || other.tag == "Bullet" || other.tag == "Spur")
        {
            Character_Ref.Health -= bDamage;
            Destroy(other.gameObject);
            healthSlider.value = Character_Ref.Health;   
        }
    }
}
