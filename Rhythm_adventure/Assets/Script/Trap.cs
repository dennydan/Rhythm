using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RhythmAssets;

public class Trap : MonoBehaviour
{
    [SerializeField] private GameObject prefabBullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Instantiate(prefabBullet, transform.position, transform.rotation);
        }
    }
}
