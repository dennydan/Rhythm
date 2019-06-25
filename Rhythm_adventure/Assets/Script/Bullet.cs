using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 20.0f;
    [SerializeField] Rigidbody2D Rigid;
    [SerializeField] Vector3 Direction = new Vector3(1, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        Rigid.velocity = Direction * speed;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Trap")
        {
            Destroy(other.gameObject);
        }
    }

}
