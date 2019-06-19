using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFollower : MonoBehaviour
{
    [SerializeField] Transform characterTransform;
    [SerializeField] float speed = 1.0f;
    Vector3 oldPosition;
    // Start is called before the first frame update
    void Start()
    {
        oldPosition = characterTransform.position;
    }

    Vector3 deltaPosition;
    // Update is called once per frame
    void Update()
    {
        deltaPosition = characterTransform.position - oldPosition;
        transform.Translate(deltaPosition.x * speed, 0, 0);
        oldPosition = characterTransform.position;
    }
}
