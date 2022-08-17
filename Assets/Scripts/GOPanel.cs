using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GOPanel : MonoBehaviour
{
    

    public void Restart()
    {
        gameObject.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
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
}
