using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DisplayScores : MonoBehaviour
{
    //array of texts to store high scores
    [SerializeField] private TextMeshProUGUI[] highScores;
    public Text[] highscoreText;
    //get a reference to Highscores class
    HighScoresTest highscoreManager;
    
    void Start()
    {
        for(int i = 0; i < highScores.Length; i++)
        {
            highScores[i].text = i + 1 + ". Fetching ...";
        }
        highscoreManager = GetComponent<HighScoresTest>();

        StartCoroutine("RefreshHighScores");
    }

    //method to assign text to score once they have been retrieved
    public void OnHighScoresDownloaded(Highscore[] highscoreList)
    {
        for (int i = 0; i < highScores.Length; i++)
        {
            highScores[i].text = i + 1 + ". ";
            if(highscoreList.Length > i)
            {
                highScores[i].text += highscoreList[i].username + " - " + highscoreList[i].score;
            }
        }
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
