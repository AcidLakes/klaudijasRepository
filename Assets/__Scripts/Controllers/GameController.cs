using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;    // text mesh pro library
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // == public fields ==
    public int StartingLives { get { return startingLives; } }
    public int RemainingLives { get { return remainingLives; } }
    public float Score { get { return score; } }

    //== private fields ==
    private float timer;
    private float score = 0;
    //private float score = PlayerPrefs.GetFloat("LevelScore");
    [SerializeField] private TextMeshProUGUI ScoreText;
    [SerializeField] private int startingLives = 3;
    private int remainingLives = 0;

    // == private methods ==
    private void Awake()
    {
        string sceneName = SceneManager.GetActiveScene().name;
       
        //if block of code added 21/4/20
        if (sceneName == "Level1")
        {
            //Debug.Log("THIS IS LEVEL ONE");

            startingLives = 5;
            score = 0;
            //PlayerPrefs.GetString("name", "noname");
        }
        else
        {
            startingLives = PlayerPrefs.GetInt("LevelLives");
            score = PlayerPrefs.GetFloat("LevelScore");
        }
        Debug.Log("Lives: " + startingLives + " score: " + score);

    }
    private void Start()
    {
        //score = 0;
        UpdateScore();
        remainingLives = startingLives;
    }
    void Update()
    {
        UpdateScore();

    }
    private void UpdateScore()
    {
        
        // display on screen
        timer += Time.deltaTime;

        if (timer > 0f)
        {
            
            score += 0.25f;
            //score = PlayerPrefs.GetFloat("LevelScore");
            if (score % 10 == 0)
            {
                //score = PlayerPrefs.GetFloat("LevelScore");//scenario1
                //score = score / 4;
                Debug.Log("Score: " + score / 10);
                float edittedScore = score / 10;
                //edittedScore = PlayerPrefs.GetFloat("LevelScore");//scenario2
                PlayerPrefs.SetFloat("LevelScore", edittedScore);
                ScoreText.text = edittedScore.ToString();
               
            }
            
        }
    }
    public void LoseOneLife()
    {
        remainingLives--;
        UpdateScore();
    }
    public void AddOneLife()
    {
        remainingLives++;
    }
}
