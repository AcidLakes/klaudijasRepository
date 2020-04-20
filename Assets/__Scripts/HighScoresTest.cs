﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class HighScoresTest : MonoBehaviour
{
    const string privateCode = "9fVO9DrTKkCZbX604kKDHwdsJzWkzU30C6DhR8ucXJxw";
    const string publicCode = "5e9b65210cf2aa0c28aa2b23";
    const string webURL = "http://dreamlo.com/lb/";

    public Highscore[] highscoresList;

    private void Awake()
    {
        AddNewHighscore("Shirin", 500);
        AddNewHighscore("Grace", 1501);
        AddNewHighscore("Klaudija", 1500);

        DownloadHighscore();
    }
    public void AddNewHighscore(string username, int score)
    {
        StartCoroutine(UploadNewHighScore(username, score));
    }

    IEnumerator UploadNewHighScore(string username, int score)
    {
        WWW www = new WWW(webURL + privateCode + "/add/" + WWW.EscapeURL(username) + "/" + score);
        yield return www;

        if (string.IsNullOrEmpty(www.error))
        {
            Debug.Log("Upload Successful");
        }
        else
        {
            Debug.Log("Error uploading: " + www.error);
        }
    }

    public void DownloadHighscore()
    {
        StartCoroutine("DownloadHighScoreDB");
    }
    //using a coroutine
    IEnumerator DownloadHighScoreDB()
    {
        WWW www = new WWW(webURL + publicCode + "/pipe/");
        yield return www;

        if (string.IsNullOrEmpty(www.error))
        {
            FormatHighScore(www.text);
        }
        else
        {
            Debug.Log("Error downloading: " + www.error);
        }
    }
    void FormatHighScore(string textStream)
    {
        string[] entries = textStream.Split(new char[] { '\n' }, System.StringSplitOptions.RemoveEmptyEntries);
        highscoresList = new Highscore[entries.Length];
        for(int i = 0; i < entries.Length; i++)
        {
            string[] entryInfo = entries[i].Split(new char[] { '|' });
            string username = entryInfo[0];
            int score = int.Parse(entryInfo[1]);
            highscoresList[i] = new Highscore(username, score);
            print(highscoresList[i].username + ": "+ highscoresList[i].score);
            //Debug.Log(highscoresList[i].username + ": " + highscoresList[i].score);
        }
    }
}
//datastructure
public struct Highscore
{
    public string username;
    public int score;
    public Highscore(string _username, int _score)
    {
        username = _username;
        score = _score;
    }
}
//https://www.youtube.com/watch?v=KZuqEyxYZCc
//https://www.youtube.com/watch?v=9jejKPPKomg