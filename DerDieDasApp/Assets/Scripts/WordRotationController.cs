using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WordRotationController : MonoBehaviour
{
    [SerializeField] private QuizController game;
    [SerializeField] private int currentWordNumber;
    [SerializeField] private AnswerButtonState derButton;
    [SerializeField] private AnswerButtonState dieButton;
    [SerializeField] private AnswerButtonState dasButton;
    [SerializeField] private Toggle tippButton;
    [SerializeField] private Image targetImage;
    [SerializeField] private TextMeshProUGUI tippText;
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private Toggle favButton;
    [SerializeField] public LevelSet[] levelSet;

    // Start is called before the first frame update
    void Start()
    {
        SetLevel();
    }

    public void SetLevel()
    {
        //add image to screen
        targetImage.sprite = levelSet[currentWordNumber].image;

        //set proper button as right button
        switch (levelSet[currentWordNumber].rightAnswer)
        {
            default:
                derButton.SetButtonState(false);
                dieButton.SetButtonState(false);
                dasButton.SetButtonState(false);
                break;
            case 1:
                derButton.SetButtonState(true);
                dieButton.SetButtonState(false);
                dasButton.SetButtonState(false);
                break;
            case 2:
                derButton.SetButtonState(false);
                dieButton.SetButtonState(true);
                dasButton.SetButtonState(false);
                break;
            case 3:
                derButton.SetButtonState(false);
                dieButton.SetButtonState(false);
                dasButton.SetButtonState(true);
                break;
        }

        //add tipp text
        tippText.text = levelSet[currentWordNumber].tippText;

        //add music
        musicSource.clip = levelSet[currentWordNumber].music;

        //add fav state
        favButton.isOn = levelSet[currentWordNumber].isFav;
    }

    public void ChangeLevel(int number)
    {
        currentWordNumber = number;
    }

    public void IncrementLevel()
    {
        if (currentWordNumber + 1 < levelSet.Length)
        {
            currentWordNumber += 1;
        } else
        {
            currentWordNumber = 0;
        }
    }

    public void DecrementLevel()
    {
        currentWordNumber -= 1;
        if (currentWordNumber < 0)
        {
            currentWordNumber = 0;
        }
    }

    public void SwitchFavouriteToggle()
    {
        levelSet[currentWordNumber].isFav = favButton.isOn;
    }
}

[Serializable]
public class LevelSet
{
    public Sprite image;
    public int rightAnswer;  //1,2,3
    public AudioClip music;
    public bool isFav;
    public string tippText = "";

}