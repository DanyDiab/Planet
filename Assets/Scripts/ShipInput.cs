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
    bool canShoot;
    public ShipProj shipProj;
    
    void Start()
    {
        entity = GetComponent<Entity>();
        canShoot = true;
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
        if(Input.GetKey(KeyCode.Space) && canShoot){
            StartCoroutine(Shoot());
        }
    }
    void rotate(int rotateDir){
        entity.transform.Rotate(0, 0, entity.getRotationSpeed() * Time.deltaTime * rotateDir);
    }
    IEnumerator Shoot(){
        canShoot = false;
        var newProj = Instantiate(shipProj, transform.position,transform.rotation);
        newProj.setShooter(entity);
        yield return new WaitForSeconds(entity.getFireRate());
        canShoot = true;
    }
}
