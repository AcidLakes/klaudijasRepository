using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetPlayerScoreLives : MonoBehaviour
{
    float l_score;
    int l_lives;
    string l_name;
    [SerializeField] private TextMeshProUGUI scoresDisplay;
    public GUIStyle guiStyle = new GUIStyle();//variable for gui style 
    // Start is called before the first frame update
    void Start()
    {
        //Fetch the PlayerPref settings
        SetText();
    }

    void SetText()
    {
        //Fetch the score from the PlayerPrefs (set these Playerprefs in another script). If no Int of this name exists, the default is 0.
        l_score = (PlayerPrefs.GetFloat("LevelScore")/10);
        Debug.Log("Score on level complete: " + l_score);
        //PlayerPrefs.SetFloat("LevelScore", (l_score/10));

        l_lives = PlayerPrefs.GetInt("LevelLives");
        l_name = PlayerPrefs.GetString("name");
    }
    //may need to remove the update method 
    void Update()
    {
        //HighScoresTest.AddNewHighscore(username, score);
    }
    void OnGUI()
    {
        //guiStyle.fontSize = 16; //change the font size
        //guiStyle.fontStyle = ;
        //Fetch the PlayerPrefs settings and output them to the screen using Labels
        //GUI.Label(new Rect(180, 180, 200, 50), "Name : " + l_name, guiStyle);
        //GUI.Label(new Rect(180, 200, 200, 50), "Score : " + l_score, guiStyle);
        //GUI.Label(new Rect(180, 220, 200, 50), "Lives : " + l_lives, guiStyle);
        //HighScoresTest.AddNewHighscore(l_name, l_score);
        Debug.Log("SCORE IN PREFS: " + PlayerPrefs.GetFloat("LevelScore"));
        scoresDisplay.text = ("Name : " + l_name + "\nScore : " + l_score + " Lives : " + l_lives);

    }
}
//https://docs.unity3d.com/ScriptReference/PlayerPrefs.GetInt.html
//https://answers.unity.com/questions/13944/change-gui-font-size-and-color.html