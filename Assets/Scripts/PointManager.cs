using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    static int points = 0;
    static int asteroid = 50;
    public TextMeshProUGUI text;
    static PointManager instance;

    void Awake(){
        if(instance == null){
            instance = this;
        }
        else{
            Destroy(gameObject);
        }
    }


    // Start is called before the first frame update

    public static void addAsteroid(){
        points += asteroid;
        instance.updateText();
        
    }
    public void updateText(){
        text.text = "Points: " + points;
    }


    public static int getPoints(){
        return points;
    }
}
