using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{

    [SerializeField] GameObject _levelSelectPanel, _mainMenuPanel, _marketPanel;
    
 
    public void LevelSelect()
    {
        gameObject.GetComponent<AudioSource>().Play();
        _levelSelectPanel.SetActive(true);
        _mainMenuPanel.SetActive(false);
    }


    public void Back()
    {
        gameObject.GetComponent<AudioSource>().Play();
        _levelSelectPanel.SetActive(false);
        _mainMenuPanel.SetActive(true);
        _marketPanel.SetActive(false);

    }

    public void Sepet()
    {
        gameObject.GetComponent<AudioSource>().Play();
        _marketPanel.SetActive(true);
        _mainMenuPanel.SetActive(false);
    }
    
    public void Quit()
    {
        gameObject.GetComponent<AudioSource>().Play();
        Application.Quit();
    }
}
