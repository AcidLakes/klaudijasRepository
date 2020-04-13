﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCounter : MonoBehaviour
{
    // == private fields ==
    [SerializeField] private LifeIcon lifeIconPrefab; // coffee cup
    //private Queue<LifeIcon> lives = new Queue<LifeIcon>();
    private List<LifeIcon> lives = new List<LifeIcon>(12);
    private int startingLives;  // read from the Game Controller
    private GameController gc;

    int hit = 0;
    void Start()
    {
        // get the GameController object
        gc = FindObjectOfType<GameController>();
        if (gc)
        {
            // retrieve the starting lives value
            // set up a read only public property to return
            // the number of starting lives
            startingLives = gc.StartingLives;
            CreateIcons();
        }
    }

    private void CreateIcons()
    {
        // show the appropriate number of coffee cups on the screen
        // use a loop
        for (int i = 0; i < startingLives; i++)
        {
            lives.Add(Instantiate(lifeIconPrefab, transform));
            //lives.Enqueue(Instantiate(lifeIconPrefab, transform));
        }
    }

    public void updateLives()
    {
        hit++;
        if (lives.Count > 0)
        {
            //lives.RemoveAt(0);
            Destroy(lives[hit-1].gameObject);
        }
        if(lives.Count <= 0)
        {
            // load game Over scene
        }
    }
}
