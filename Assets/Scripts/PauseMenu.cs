using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] GameObject _pauseMenu;

    public void PauseButton()
    {
        Time.timeScale = 0;
        _pauseMenu.SetActive(true);

    }


    public void Resume()
    {
        
        gameObject.GetComponent<AudioSource>().Play();
        _pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        gameObject.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void Quit()
    {
        gameObject.GetComponent<AudioSource>().Play();
        Application.Quit();
    }




}
