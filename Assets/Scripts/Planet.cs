using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Planet : Entity
{

    // Start is called before the first frame update
    public override void Start()
    {
        HP = 20;
        speed = 0;
    }

    public void isGameOver(){
        if(HP <= 0){
            SceneManager.LoadScene("GameOver");
        }
    }

}
    
