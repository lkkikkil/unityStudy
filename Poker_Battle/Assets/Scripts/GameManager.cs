﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    public void GameExit()
    {
        Application.Quit();
    }

    public void GameStart()
    {
        LoadInGameScene();
    }

    public void LoadInGameScene()
    {
        SceneManager.LoadScene("InGame");
    }
}
