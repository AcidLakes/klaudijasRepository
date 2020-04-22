using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameEntry : MonoBehaviour
{
    public string nameEntered;
    public int score = 1900;
    public GameObject inputField;
    //where you want to display the output
    public GameObject textDisplay;

    //button 
    public void StoreName()
    {
        nameEntered = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "Welcome to the game " + nameEntered;
        //HighScoresTest.AddNewHighscore("Polly", 1900);
        PlayerPrefs.SetString("name", nameEntered);
    }
    /*public void PublicName()
    {
        HighScoresTest.AddNewHighscore(nameEntered, 1900);
    }*/
}
//https://www.youtube.com/watch?v=2liZtyMhIQQ
