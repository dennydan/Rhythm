using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 20.0f;
    [SerializeField] Rigidbody2D Rigid; 

    // Start is called before the first frame update
    void Start()
    {
        Rigid.velocity = transform.right * speed;
    }

    // Update is called once per frame

}
