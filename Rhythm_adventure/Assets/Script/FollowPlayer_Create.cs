using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer_Create : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.name == "End")
        {
            Instantiate(other.transform.root.gameObject, other.transform.position, other.transform.rotation);
            Debug.Log("End");
        }
    }
}
