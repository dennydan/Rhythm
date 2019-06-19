using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RhythmAssets;

public class Weapon_Ax : MonoBehaviour
{
    public Transform ShooterPoint;
    [SerializeField] private float shootRange = 8.0f;

    private Animator WarriorAnim;
    private ParticleSystem particleEffect;
    private LineRenderer AxLineRenderer;

    // Start is called before the first frame update
    void Start()
    {
      
        particleEffect = ShooterPoint.GetComponent<ParticleSystem>();
        AxLineRenderer = ShooterPoint.GetComponent<LineRenderer>();
        WarriorAnim = GetComponentInParent<Animator>();   
    }
    private bool isFire = false;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(Shoot());
        }
    }
    
    IEnumerator Shoot()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(ShooterPoint.position, ShooterPoint.right, shootRange);

        if(hitInfo)
        {
            if(hitInfo.transform.tag == "Obstacle" && hitInfo.transform != null)
            {
                particleEffect.transform.position = hitInfo.point;
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Obstacle" && WarriorAnim.GetBool("Attacking"))
        {
            Destroy(other.gameObject);
            
        }
    }
}
