using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject main_menu;
    public GameObject credits_menu;
    public void Quit()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void Credits()
    {
        main_menu.SetActive(false);
        credits_menu.SetActive(true);
    }

    public void Back()
    {
        credits_menu.SetActive(false);
        main_menu.SetActive(true);
    }

}
