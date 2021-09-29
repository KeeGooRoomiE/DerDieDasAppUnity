using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleSoundBehaviour : MonoBehaviour
{

    private Toggle toggle;
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

    IEnumerator RestartToggle()
    {
        yield return new WaitForSeconds(1);
        toggle.isOn = false;
    }
}
