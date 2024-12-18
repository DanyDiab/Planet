using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEditor;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    Ship ship;
    void Start(){
        ship = FindObjectOfType<Ship>();
        if(ship != null){
            ship.OnLevelUp += chooseUpgrade;
        }
    }



    void chooseUpgrade(int amt){
        
    }
    void addUpgradeEffect(){
        
    }

    

    

}
