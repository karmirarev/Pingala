using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject EndGamePanel;
    public GameObject WinMessage;
    public GameObject LossMessage;

    void Start()
    {
        MenuPanel.SetActive(false);
        EndGamePanel.SetActive(false);
    }

    public void ShowMenuPanel()
    {
        if (MenuPanel != null)
        {
            MenuPanel.SetActive(!MenuPanel.activeSelf);
        }
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void NewGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void GiveUp()
    {
        EndGamePanel.SetActive(true);
        LossMessage.SetActive(true);
    }

    public void BackToGame()
    {
        MenuPanel.SetActive(false);
    }
}
