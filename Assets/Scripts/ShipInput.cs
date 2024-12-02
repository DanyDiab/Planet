using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

public class ShipInput : MonoBehaviour
{
    Ship ship;
    bool canShoot;
    public ShipProj shipProj;
    bool accelerate;
    bool decellerate;
    
    void Start()
    {
        ship = GetComponent<Ship>();
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
        updateSpeed();
    }
    void rotate(int rotateDir){
        ship.transform.Rotate(0, 0, ship.getRotationSpeed() * Time.deltaTime * rotateDir);
    }
    void updateSpeed()
    {
        if (Input.GetKey(KeyCode.W) && !accelerate)
        {
            accelerate = true;
            decellerate = false;
            StartCoroutine(Accelerate());
        }
        else if (!Input.GetKey(KeyCode.W) && accelerate)
        {
            accelerate = false;
        }

        if (Input.GetKey(KeyCode.S) && !decellerate)
        {
            decellerate = true;
            accelerate = false;
            StartCoroutine(Deccelerate());
        }
        else if (!Input.GetKey(KeyCode.S) && decellerate)
        {
            decellerate = false;
        }
    }

    IEnumerator Shoot(){
        canShoot = false;
        var newProj = Instantiate(shipProj, transform.position,transform.rotation);
        newProj.setShooter(ship);
        yield return new WaitForSeconds(ship.getFireRate());
        canShoot = true;
    }
    IEnumerator Accelerate()
    {
        while (accelerate && ship.getSpeed() < ship.getFastSpeed())
        {
            ship.setSpeed(ship.getSpeed() + ship.getAccelrationInterval()); // Gradually increase speed
            yield return new WaitForSeconds(0.1f);   // Adjust time step for smoothness
        }
    }

    IEnumerator Deccelerate()
    {
        while (decellerate && ship.getSpeed() > ship.getSlowSpeed())
        {
            ship.setSpeed(ship.getSpeed() - ship.getAccelrationInterval()); // Gradually decrease speed
            yield return new WaitForSeconds(0.1f);   // Adjust time step for smoothness
        }
    }
}
