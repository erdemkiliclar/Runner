using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Marketing : MonoBehaviour
{
    [SerializeField] Button _satinAl;
    

    public void SatinAl()
    {
        gameObject.GetComponent<AudioSource>().Play();
        if (GameManager._coinValue < 10)
        {
            _satinAl.interactable = false;
        }
        else 
        {
            GameManager._coinValue = GameManager._coinValue - 10;
            GameManager._canValue++;
            PlayerPrefs.SetInt("CanValue", GameManager._canValue);
            PlayerPrefs.SetInt("CoinValue", GameManager._coinValue);
        }
    }




}
