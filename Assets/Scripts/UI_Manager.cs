using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Timeline.TimelinePlaybackControls;
/*
 * Ravandi, Luca
 * 4/17/2025
 * Instructions for Menu UI
 */


public class Ui_Manager : MonoBehaviour
{
    public TMP_Text HealthText;
    public Controller Controller;
    void Update()
    {
        HealthText.text = "Health: " + Controller.health;
    }

    public void PlayButtonPressed(int buildIndex)
    {
        SceneManager.LoadScene(1);
    }

    public void QuitButtonPressed(int buildIndex)
    {
        Application.Quit();
    }
}
