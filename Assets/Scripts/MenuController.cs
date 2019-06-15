using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuGO;
    [SerializeField] private GameObject settingsMenuGO;
    [SerializeField] private GameObject aboutMenuGO;

    private GameObject currentMenu;

    public void goToMain()
    {
        currentMenu.SetActive(false);
        currentMenu = mainMenuGO;
        currentMenu.SetActive(true);
    }

    public void goToSettings()
    {
        currentMenu.SetActive(false);
        currentMenu = settingsMenuGO;
        currentMenu.SetActive(true);
    }

    public void goToAbout()
    {
        currentMenu.SetActive(false);
        currentMenu = aboutMenuGO;
        currentMenu.SetActive(true);
    }

    public void quit()
    {
        Application.Quit();
    }

    public void goToGame()
    {
        SceneManager.LoadScene("Game");
    }

}
