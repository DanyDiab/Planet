using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : Proj
{
    // Start is called before the first frame update
    public Asteroid asteroid;

    void Start(){
        StartCoroutine(Spawn());
    }
    
    IEnumerator Spawn(){
        int randX = Random.Range(-50, 50);
        int randY = Random.Range(-50, 50);
        Vector3 randPos = new Vector3(randX, randY, 1);
        Instantiate(asteroid, randPos, transform.rotation);
        yield return new WaitForSeconds(2f);
        StartCoroutine(Spawn());
    }
}
