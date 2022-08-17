using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _coinText, _canText, _levelText;
    public static int _coinValue;
    public static int _canValue;

    private void Awake()
    {
        //PlayerPrefs.DeleteAll();
        _levelText.text = ("LEVEL: " + SceneManager.GetActiveScene().buildIndex);
        _coinValue = PlayerPrefs.GetInt("CoinValue", 0);
        _canValue = PlayerPrefs.GetInt("CanValue", 0);
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            _levelText.text = ("");
        }
    }

    private void Update()
    {
        _coinText.text = _coinValue.ToString();
        _canText.text = _canValue.ToString();
       
    }

}
