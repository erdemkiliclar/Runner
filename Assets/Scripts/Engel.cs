using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Engel : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _coinText;
    static int _coinCount;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            Destroy(this.gameObject);
            _coinCount = _coinCount + 1;
            _coinText.text = ($"{_coinCount}");
            Debug.Log("Aldý");
        }
    }

}
