using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADsDelegate : MonoBehaviour
{
    [SerializeField] private AdsLoader ads;
    // Start is called before the first frame update
    void OnEnable()
    {
        ads.ShowInterstitial();
    }
}
