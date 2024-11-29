using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Entity entity;

    // Start is called before the first frame update
    void Start()
    {
        entity = GetComponent<Entity>();
    }
    void Update()
    {
        move();
    }

    void move()
    {
        if (entity is Ship){
            shipMove();
        }
        else{
            entityMove();
        }
    }

    void shipMove()
    {
        UnityEngine.Vector3 forward = entity.transform.up;
        UnityEngine.Vector3 move = entity.transform.position + forward * entity.getSpeed() * Time.deltaTime;
        entity.transform.position = move;
    }

    void entityMove()
    {
        Debug.Log("Generic entity is moving");
    }
}
