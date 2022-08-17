using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuAnim : MonoBehaviour
{

    [SerializeField] Animator _animator;


    private void Update()
    {

        _animator.Play("MenuAnimation");
        
    }





}
