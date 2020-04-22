using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    /*private void Awake()
    {
        float score = PlayerPrefs.GetFloat("LevelScore");
        string username = PlayerPrefs.GetString("name");
        Debug.Log("IN HIGH SCORE: " + PlayerPrefs.GetFloat("LevelScore"));
        HighScoresTest.AddNewHighscore(username, score);
    }*/
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {

            //float score = PlayerPrefs.GetFloat("LevelScore");
            //string username = PlayerPrefs.GetString("name");
           /* float score = Random.Range(0, 2000);

            //Debug.Log("Display " + score);
            string username = "";
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            //Random.Range(5,10) gives a name of random lenght between 5 and 10 chars
            for(int i = 0; i < Random.Range(5,10); i++)
            {
            username += alphabet[(Random.Range(0, alphabet.Length))];
            }*/
            //name uploads but the score doesn't - look at LevelScore again
            float score = PlayerPrefs.GetFloat("LevelScore");
            string username = PlayerPrefs.GetString("name");
            
            HighScoresTest.AddNewHighscore(username, score);
        }
    }
}
