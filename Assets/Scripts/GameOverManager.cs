using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public TextMeshProUGUI text; 
    static GameOverManager instance;

    void Awake(){
        if(instance == null){
            instance = this;
        }
        else{
            Destroy(gameObject);
        }
        instance.updateText();
    }
    void updateText(){
        text.text = "Game Over!\nPoints: " + PointManager.getPoints();
    }
    public void restart(){
        SceneManager.LoadScene("Main");
    }
}
