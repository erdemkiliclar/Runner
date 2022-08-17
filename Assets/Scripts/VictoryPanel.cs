using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryPanel : MonoBehaviour
{
    public int _sonrakiSahne;
    [SerializeField] GameObject _youWinPanel, _victoryPanel;
    
     private void Awake()
    {
        _sonrakiSahne = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public void NextLevel()
    {

        gameObject.GetComponent<AudioSource>().Play();

        if (SceneManager.GetActiveScene().buildIndex != 15)
        {

            SceneManager.LoadScene(_sonrakiSahne);

        }
        if (SceneManager.GetActiveScene().buildIndex == 15)
        {

            _youWinPanel.SetActive(true);
            _victoryPanel.SetActive(false);

        }
        else if (_sonrakiSahne > PlayerPrefs.GetInt("_levelAt"))
        {
            PlayerPrefs.SetInt("_levelAt", _sonrakiSahne);
        }
    }

    public void MainMenu()
    {
        gameObject.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        gameObject.GetComponent<AudioSource>().Play();
        Application.Quit();
    }

    public void Play()
    {
        gameObject.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene( PlayerPrefs.GetInt("_levelAt", _sonrakiSahne));
    }



}
