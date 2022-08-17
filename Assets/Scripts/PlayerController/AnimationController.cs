using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] GameObject _main;
    [SerializeField] Animator _animator;
    [SerializeField] Rigidbody _rigidbody;
    [SerializeField] GameObject _goPanel;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && GameManager._canValue ==0)
        {
            _animator.SetBool("__isDead", true);
            _main.GetComponent<PlayerController>().enabled = false;
            _goPanel.SetActive(true);
            
        }
        else
        {
            Destroy(this.gameObject);
            GameManager._canValue--;
            PlayerPrefs.SetInt("CanValue", GameManager._canValue);
            _animator.SetBool("__isDead", false);
        }
    }


    


}
