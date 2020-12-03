using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    private static UIManager _instance;

    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<UIManager>();
            }

            return _instance;
        }
    }
    
    public Text scoreText;
    public GameObject gamePanel;
    public GameObject gameOverPanel;

    //We update the on screen displayed score over here
    public void UpdateScore(int playscore)
    {   
        playscore+=0;
        scoreText.text = playscore.ToString();
    }

    public void GameOver()
    {
        gamePanel.SetActive(false);
        gameOverPanel.SetActive(true);
    }

}
