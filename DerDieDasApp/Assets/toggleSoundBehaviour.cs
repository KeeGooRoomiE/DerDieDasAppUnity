using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleSoundBehaviour : MonoBehaviour
{

    private Toggle toggle;
    [SerializeField] private AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        toggle = gameObject.GetComponent<Toggle>();
    }

    public void toggleSequence()
    {
        //
        StartCoroutine(RestartToggle());   
    }

    public void StartSound()
    {
        if (toggle.isOn)
        {
            sound.Play();
        }
    }

    IEnumerator RestartToggle()
    {
        yield return new WaitForSeconds(1);
        toggle.isOn = false;
    }
}
