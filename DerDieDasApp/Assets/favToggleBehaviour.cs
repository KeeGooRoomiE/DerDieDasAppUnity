using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class favToggleBehaviour : MonoBehaviour
{
    private Toggle toggle;
    [SerializeField] private CardSetupManager game;
    // Start is called before the first frame update
    void Start()
    {
        toggle = gameObject.GetComponent<Toggle>();
    }

    // Update is called once per frame
    void Update()
    {
        if (game.selectedTheme == 0)
        {
            toggle.interactable = false;
            toggle.isOn = true;
        } else
        {
            toggle.interactable = true;
        }
    }
}
