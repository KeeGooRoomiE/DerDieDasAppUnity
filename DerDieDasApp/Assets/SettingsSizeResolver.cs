using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SettingsSizeResolver : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI screentitle;
    [SerializeField] private TextMeshProUGUI othertitle;
    [SerializeField] private TextMeshProUGUI field1title;
    [SerializeField] private TextMeshProUGUI field2title;
    [SerializeField] private TextMeshProUGUI field3title;
    [SerializeField] private TextMeshProUGUI field4title;
    [SerializeField] private TextMeshProUGUI field5title;
    [SerializeField] private TextMeshProUGUI field1descr;
    [SerializeField] private TextMeshProUGUI field2descr;
    [SerializeField] private TextMeshProUGUI field3descr;
    [SerializeField] private TextMeshProUGUI field4descr;
    // Start is called before the first frame update
    void Start()
    {
        float textsize = field2title.fontSize;
        field1title.fontSize = textsize;
        field3title.fontSize = textsize;
        field4title.fontSize = textsize;
        field5title.fontSize = textsize;

        float titlesize = screentitle.fontSize;
        othertitle.fontSize = titlesize;

        float descrsize = field1descr.fontSize;
        field2descr.fontSize = descrsize;
        field3descr.fontSize = descrsize;
        field4descr.fontSize = descrsize;
    }
}
