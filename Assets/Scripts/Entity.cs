using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    int speed;
    float rotationSpeed;
    float fireRate;
    // Start is called before the first frame update
    public virtual void Start()
    {
        speed = 3;
        rotationSpeed = 200f;
        fireRate = .5f;
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
}
