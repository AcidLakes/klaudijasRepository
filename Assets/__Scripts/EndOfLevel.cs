using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Utilities;


public class EndOfLevel : MonoBehaviour
{
    //private fields
    [SerializeField] private string loadScene;
    private GameController gc;
    private LifeCounter lc;
    private SceneNames sc;
    //public float levScore;//level score - may not be of any use
    //public int levLives;//level lives - may not be of any use
    // Start is called before the first frame update
    void Start()
    {
        lc = FindObjectOfType<LifeCounter>();
        gc = FindObjectOfType<GameController>();
    }

    void OnTriggerEnter(Collider other)
    {
        
        var player = other.GetComponent<Player>();
        PlayerPrefs.SetFloat("LevelScore", gc.Score); //PlayerPrefs.SetFloat("LevelScore", gc.Score/10);
        PlayerPrefs.SetInt("LevelLives", gc.RemainingLives);

        //Tag player as Player in the Inspector - click on tag dropdown and select Player
        if (player)
        {
            SceneManager.LoadSceneAsync(loadScene);
            Debug.Log("HIT END");

        }
        
    }
}
//https://www.youtube.com/watch?v=izl5VUm2Frk