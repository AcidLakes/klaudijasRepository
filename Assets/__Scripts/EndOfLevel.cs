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
    // Start is called before the first frame update
    void Start()
    {
        lc = FindObjectOfType<LifeCounter>();
        gc = FindObjectOfType<GameController>();
    }

    void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<Player>();

        //Tag player as Player in the Inspector - click on tag dropdown and select Player
        if (player)
        {
            SceneManager.LoadSceneAsync(loadScene);
            Debug.Log("HIT END");

        }
        
    }
}
//https://www.youtube.com/watch?v=izl5VUm2Frk