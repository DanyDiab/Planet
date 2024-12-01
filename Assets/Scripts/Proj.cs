using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Proj : MonoBehaviour
{
    Vector2 dir;
    float speed;
    float distanceTraveled;
    Entity shooter;
    // Start is called before the first frame update
    public virtual void Start()
    {
        distanceTraveled = 0;
    }

    protected void move(){
        // move projectile upwards relative to its rotation
        Vector2 ammtToTranslate = Vector2.up * speed * Time.deltaTime;
        transform.Translate(ammtToTranslate);
        distanceTraveled += ammtToTranslate.magnitude;
        // destory proj after it has passed its range
        destroyPassedRange();
    }

    protected void destroyPassedRange(){
        if(shooter == null){
            Debug.Log("shooter is null");
            return;
        }
        if(distanceTraveled >= shooter.getRange()){
            Destroy(gameObject);
        }
    }
    protected void calculateDir(Vector2 initial, Vector2 destination){
        dir = destination - initial;
        dir.Normalize();
        transform.rotation = Quaternion.LookRotation(Vector3.forward, dir);
    }

    public void setShooter(Entity entity){
        shooter = entity;

    }
    public Vector2 getDir(){
        return dir;
    }
    public Entity getShooter(){
        return shooter;
    }
    public void setSpeed(float speed){
        this.speed = speed;
    }

    void OnTriggerEnter2D(Collider2D other){
        Destroy(gameObject);
    }
}
