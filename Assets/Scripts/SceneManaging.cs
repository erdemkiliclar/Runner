using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManaging : MonoBehaviour
{
   
    public void ChangeScene(int sceneIndex)
    {
        gameObject.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene(sceneIndex);
    }

    public void QuitGame()
    {
        gameObject.GetComponent<AudioSource>().Play();
        Application.Quit();
    }
}
