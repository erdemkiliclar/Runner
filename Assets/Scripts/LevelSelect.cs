using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelSelect : MonoBehaviour
{
    [SerializeField] Button[] _lvlButtons;


    private void Start()
    {
        int _levelAt = PlayerPrefs.GetInt("_levelAt", 1);
        for (int i = 0; i < _lvlButtons.Length; i++)
        {
            if (i + 1 > _levelAt)
            {
                _lvlButtons[i].interactable = false;
            }
        }
    }


}
