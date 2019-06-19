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
    // Start is called before the first frame update
    private Animator CharactorAnim_ref;
    private Character_Warrior Character_Ref;
    void Start()
    {
        CharactorAnim_ref = transform.parent.GetComponent<Animator>();
        Character_Ref = transform.parent.GetComponent<Character_Warrior>();
        healthSlider.value = Character_Ref.Health;
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Arrow" || other.tag == "Obstacle")
        {
            Character_Ref.Health -= 0.1f;
            Destroy(other.gameObject);
            healthSlider.value = Character_Ref.Health;
            
        }
    }
}
