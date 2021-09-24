using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonThemeSelector : MonoBehaviour
{
    [SerializeField] private CardSetupManager manager;
    public int myTheme;

    public void SetCardsTheme()
    {
        manager.selectedTheme = myTheme;
    }
}
