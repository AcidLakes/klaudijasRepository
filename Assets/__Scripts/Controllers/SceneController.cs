﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Utilities;//scene names
//Scene Management library - load, unload scenes
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void GoToLevel1()
    {
        
        SceneManager.LoadSceneAsync(SceneNames.LEVEL_1);
    }
    public void GoToLevel2()
    {

        SceneManager.LoadSceneAsync(SceneNames.LEVEL_2);
    }
    public void GoToLevel3()
    {
        SceneManager.LoadSceneAsync(SceneNames.LEVEL_3);
    }
    public void GoToGameOver()
    {
        SceneManager.LoadSceneAsync(SceneNames.GAME_OVER);
    }
    public void GoToLevel1Complete()
    {
        SceneManager.LoadSceneAsync(SceneNames.LEVEL_1_COMPLETE);

    }
    public void GoToLevel2Complete()
    {
        SceneManager.LoadSceneAsync(SceneNames.LEVEL_2_COMPLETE);

    }
    public void GoToLevel3Complete()
    {
        SceneManager.LoadSceneAsync(SceneNames.LEVEL_3_COMPLETE);

    }
    public void GoToNameEntry()
    {
        SceneManager.LoadSceneAsync(SceneNames.NAME_ENTRY);

    }
    public void GoToOpeningScene()
    {
        SceneManager.LoadSceneAsync(SceneNames.OPENING_SCENE);

    }

    public void GoToWin()
    {
        SceneManager.LoadSceneAsync(SceneNames.WIN);
    }
    public void GoToHighScores()
    {
        SceneManager.LoadSceneAsync(SceneNames.HIGH_SCORES);

    }

    public void GoToPause1()
    {
        SceneManager.LoadSceneAsync(SceneNames.PAUSE_1);

    }
    public void GoToPause2()
    {
        SceneManager.LoadSceneAsync(SceneNames.PAUSE_2);

    }
    public void GoToPause3()
    {
        SceneManager.LoadSceneAsync(SceneNames.PAUSE_3);

    }
}
