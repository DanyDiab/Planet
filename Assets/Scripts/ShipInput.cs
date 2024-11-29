using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

public class ShipInput : MonoBehaviour
{
    Entity entity;
    void Start()
    {
        entity = GetComponent<Entity>();
    }

    void Update()
    {
        takeInput();
    }
    void takeInput(){
        if(Input.GetKey(KeyCode.A)){
            rotate(1);
        }
        if(Input.GetKey(KeyCode.D)){
            rotate(-1);
        }
        if(Input.GetKey(KeyCode.Space)){
            shoot();    
        }
    }
    void rotate(int rotateDir){
        entity.transform.Rotate(0, 0, entity.getRotationSpeed() * Time.deltaTime * rotateDir);
    }
    void shoot(){
        
    }
}
