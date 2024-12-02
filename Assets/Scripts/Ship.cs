using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ship : Entity
{
    float rotationSpeed;
    float fireRate;
    float slowSpeed;
    float fastSpeed;
    float accelrationInterval;
    

    // Start is called before the first frame update
    public override void Start()
    {
        speed = 5;
        HP = 100;
        rotationSpeed = 200f;
        fireRate = 0.5f;
        range = 100f;
        slowSpeed = 2f;
        fastSpeed = 5f;
        accelrationInterval = 0.2f;
    }
    public float getRotationSpeed(){
        return rotationSpeed;
    }
    public float getFireRate(){
        return fireRate;
    }
    
    public float getSlowSpeed(){
        return slowSpeed;
    }
    public float getFastSpeed(){
        return fastSpeed;
    }
    public float getAccelrationInterval(){
        return accelrationInterval;
    }
    

}
