using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour{
    static string command;
    public TMP_InputField inputField;
    public TMP_Text outputText;
    string commandHistory = "";
    float minWait = .02f;
    float maxWait = .1f;
    int points;
    bool gameOver;
    void Start(){
        inputField.ActivateInputField();
    }
    void Update(){
        takeInput();
    }
    public void takeInput(){
        if(Input.GetKeyDown(KeyCode.Return)){
            processCommand(inputField.text.ToLower());
            inputField.text = "";
            inputField.ActivateInputField();
        }
    }

    public void processCommand(string command){
        commandHistory = "Planet_Intruders_x86: " + command + "\n";
        if(command == "help"){
            commandHistory += "\thelp: display all commands\n";
            commandHistory += "\tquit: close the game\n";
            commandHistory += "\tstart: start the game";
        }
        else if(command == "quit"){
            UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }
        else if(command == "start"){
            SceneManager.LoadScene("Main");
        }
        else{
            commandHistory += "\tInvalid command, type 'help' to display possible commands\n";
        }
        StopAllCoroutines();
        StartCoroutine(TypeText(commandHistory));
    }

    public void GameOver(int points){
        this.points = points;
    }

    IEnumerator TypeText(string text){
        outputText.text = "";
        foreach (char letter in text){
            outputText.text += letter;
            float randWait = Random.Range(minWait,maxWait);
            Debug.Log(randWait);
            yield return new WaitForSeconds(randWait);
        }
    }
}