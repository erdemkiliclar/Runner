using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{


    public int _sonrakiSahne;

    private void Start()
    {
        _sonrakiSahne = SceneManager.GetActiveScene().buildIndex + 1;
    }





}
