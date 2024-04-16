using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;


public class IHM : MonoBehaviour
{
    public List<Transform> LifePanelTransform;
    public static IHM Instance;
    public GameObject[] lifes = new GameObject[4];
    [SerializeField]
    TextMeshProUGUI score, life;
    private int i;
    private int value;
    [SerializeField] GameObject gameOverGo;
    void Start()

    {
        DisplayGameOverMenu(false);
        
        Debug.Log("nbre image " + lifes.Length);
    }
    private void Awake()
    {
        Instance = this;
    }
    public void UpdateLife()
    {
        life.text = "life " + InfosPlayer.Instance.life;
        foreach (Transform child in LifePanelTransform)
        {
            child.gameObject.SetActive(false);
        }
        for (int i = 0; i < InfosPlayer.Instance.life; i++)
        {
            LifePanelTransform[i].gameObject.SetActive(true);

        }
    }
    public void UpdateScore()
    {
        score.text = "score " + InfosPlayer.Instance.score;
    }

    public void OnRestartButtonClick()
    {
        SceneManager.LoadScene("GameScene");
       
    }
    public void OnMainMenuButtonClick()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void DisplayGameOverMenu(bool setActive)
    {
        gameOverGo.SetActive(setActive);
    }
}

