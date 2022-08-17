using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Coin : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _coinText;
    //static int _coinCount;

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            GameManager._coinValue++;

            Destroy(this.gameObject);
            //_coinCount = _coinCount + 10;
            //_coinText.text = ($"{_coinCount}");
            Debug.Log("Aldý");
        }
    }

}
