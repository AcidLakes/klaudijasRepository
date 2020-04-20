using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScores : MonoBehaviour
{
    //array of texts to store high scores
    public Text[] highscoreText;
    //get a reference to Highscores class
    HighScoresTest highscoreManager;
    
    void Start()
    {
        for(int i = 0; i < highscoreText.Length; i++)
        {
            highscoreText[i].text = i + 1 + ". Fetching ...";
        }
        highscoreManager = GetComponent<HighScoresTest>();

        StartCoroutine("RefreshHighScores");
    }

   IEnumerator RefreshHighScores()
    {
        while (true)
        {
            highscoreManager.DownloadHighscore();
            yield return new WaitForSeconds(30);
        }
    }
}
