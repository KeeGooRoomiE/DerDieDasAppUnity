using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsTransitionSelector : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject game;
    [SerializeField] private GameObject settings;
    public int screenSelection;

public void OpenScreen()
    {
        if (screenSelection == 0)
        {
            settings.SetActive(false);
            menu.SetActive(true);
        }
        else
        {
            settings.SetActive(false);
            game.SetActive(true);
        }
    }

    public void ChangeSelection(int screen)
    {
        screenSelection = screen;
    }
}

