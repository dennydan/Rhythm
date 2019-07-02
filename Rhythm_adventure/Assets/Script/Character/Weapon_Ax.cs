using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RhythmAssets;

public class Weapon_Ax : MonoBehaviour
{
    public Transform ShooterPoint;
    [SerializeField] private float shootRange = 8.0f;
    [SerializeField] private GameObject bulletPrefab;

    private Animator WarriorAnim;
    private ParticleSystem particleEffect;
    private LineRenderer AxLineRenderer;
    private Character_Warrior Warrior_Ref;

    // Start is called before the first frame 
    private void Awake()
    {
        particleEffect = ShooterPoint.GetComponent<ParticleSystem>();
        AxLineRenderer = ShooterPoint.GetComponent<LineRenderer>();
        WarriorAnim = GetComponentInParent<Animator>();
        Warrior_Ref = GetComponentInParent<Character_Warrior>();
    }
    private bool isFire = false;
    // Update is called once per frame
    void Update()
    {
       
    }
    //There are two ways to shoot.
    //Bullet
    public void Shoot_Bullet()
    {
        Instantiate(bulletPrefab, ShooterPoint.position, ShooterPoint.rotation);
    }
    //LineRenderer
    IEnumerator Shoot_Line()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(ShooterPoint.position, ShooterPoint.right, shootRange);
        
        
        if(hitInfo)
        {
            if(hitInfo.transform.tag == "Obstacle" && hitInfo.transform != null)
            {
                //particleEffect.transform.position = hitInfo.point;
                particleEffect.Stop();
                particleEffect.Play();
                Destroy(hitInfo.transform.gameObject);
            }
            
            AxLineRenderer.SetPosition(0, ShooterPoint.position);
            AxLineRenderer.SetPosition(1, hitInfo.point);
        }
        else
        {
            AxLineRenderer.SetPosition(0, ShooterPoint.position);
            AxLineRenderer.SetPosition(1, ShooterPoint.position + ShooterPoint.right * 100);
        }
        AxLineRenderer.enabled = true;
        yield return 0;
        AxLineRenderer.enabled = false;
        
    }
    private void disableEffect()
    {
    
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Obstacle" && WarriorAnim.GetBool("Attacking"))
        {
            Warrior_Ref.Rhythm_GM.Score += 10;
            Destroy(other.gameObject);
            Debug.Log(Warrior_Ref.Rhythm_GM.Score);
        }
    }
}
