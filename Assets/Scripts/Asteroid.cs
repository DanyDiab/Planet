using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : Proj
{
    // Start is called before the first frame update
    void Start()
    {
        base.Start();
        setSpeed(2);
        Vector2 test = new Vector2(0,0);
        calculateDir(transform.position, test);
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
}
