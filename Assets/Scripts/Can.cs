using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Can : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI _canText;
    



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager._canValue++;
            Destroy(this.gameObject);
            
            Debug.Log("Aldý");
        }
    }




}
