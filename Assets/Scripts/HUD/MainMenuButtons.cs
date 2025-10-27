using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuButtons : MonoBehaviour
{
    public GameObject InstructionsPanel;

    public void NewGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ContinueGame()
    {
        // Load the last saved game state.
        Debug.Log("Continue Game button clicked.");
    }

    public void Instructions()
    {
        if (InstructionsPanel != null)
        {
            InstructionsPanel.SetActive(!InstructionsPanel.activeSelf);
        }
    }

    public void BackToMainMenu()
    {
        InstructionsPanel.SetActive(false);
    }
}
