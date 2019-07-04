using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RhythmAssets;

public class FollowPlayer_Destroy : MonoBehaviour
{
    [SerializeField] Character_Warrior Warrior_Ref;

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
            Destroy(other.transform.parent.gameObject);
        }else if(other.name == "EndGame")
        {
            // Logic of EndGame 
        }
        else
        {
            Destroy(other.gameObject);
        }

    }
}
