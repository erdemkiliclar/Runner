using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] GameObject _victoryPanel;
    [SerializeField] GameObject _main;
    [SerializeField] Animator _animator;
    [SerializeField] GameObject _particalEffect;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _particalEffect.SetActive(true);
            PlayerPrefs.SetInt("CoinValue", GameManager._coinValue);
            PlayerPrefs.SetInt("CanValue", GameManager._canValue);
            _victoryPanel.SetActive(true);
            _main.SetActive(false);
            _animator.Play("Victory");

        }
        else
        {
            _particalEffect.SetActive(false);
        }
    }

}
