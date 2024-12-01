using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    int speed;
    float rotationSpeed;
    float fireRate;
    float range;
    // Start is called before the first frame update
    public virtual void Start()
    {
        speed = 3;
        rotationSpeed = 100f;
        fireRate = .5f;
        range = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getSpeed(){
        return speed;
    }

    public float getRotationSpeed(){
        return rotationSpeed;
    }
    public float getFireRate(){
        return fireRate;
    }
    
    public float getRange(){
        return range;
    }
}
