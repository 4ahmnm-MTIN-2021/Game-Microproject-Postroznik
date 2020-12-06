using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class Sceneloader : MonoBehaviour
{
    public int numberPress=0;
    public InputField nameInput;
    public PlayerName playerName;
    public GameObject buttonPressText;
    public void addButtenPress()
    {
        numberPress++;
        buttonPressText.GetComponent<Text>().text = numberPress.ToString();
        if (numberPress == 5)
        {
            LoadNextScene("SceneAdd");
        }
    }
    public void LoadNextScene(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void UpdatePlayerName()
    {
        playerName.runtimevalue = nameInput.text;
    }
    
}
