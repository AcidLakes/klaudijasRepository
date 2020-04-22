using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Utilities;

public class PlayerScoresLives : MonoBehaviour {
    
    //private fields
    [SerializeField] private string loadScene;
    private GameController gc;
    private LifeCounter lc;
    private SceneNames sc;
    

    // Start is called before the first frame update
   /* void Start()
    {
        PlayerPrefs.SetFloat("LevelScore", 0.0f);
        PlayerPrefs.SetInt("LevelLives", 3);
    }*/

    void OnGUI()
    {
        //Create a button which loads the appropriate level when you press it
        if (GUI.Button(new Rect(10, 30, 200, 60), "Next Scene"))
        {
            SceneManager.LoadScene(loadScene);
        }
    }
    //https://docs.unity3d.com/ScriptReference/PlayerPrefs.SetInt.html
}
