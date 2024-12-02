using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ShipProj : Proj
{
    
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
        setSpeed(20);
    }

    // Update is called once per frame
    void Update()
    {
        move();
        destroyPassedRange();
    }
}
