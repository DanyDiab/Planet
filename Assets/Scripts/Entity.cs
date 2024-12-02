using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    protected float speed;
    protected int HP;
    protected float range;

    // Start is called before the first frame update
    public virtual void Start()
    {
        
    }

    public float getSpeed(){
        return speed;
    }
    public void setSpeed(float speed){
        this.speed = speed;
    }
    
    public float getRange(){
        return range;
    }
    public void takeDamage(){
        HP--;
    }
    public int getHP(){
        return HP;
    }


}
