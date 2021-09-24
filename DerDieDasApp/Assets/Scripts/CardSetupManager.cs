using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardSetupManager : MonoBehaviour
{
    [SerializeField] private QuizController game;
    [SerializeField] private FlashcardsManager cards;
    [SerializeField] public int selectedLevel;
    [SerializeField] public int selectedTheme;
    [SerializeField] private int currentWordNumber;
    [SerializeField] private bool cardFavIsOn;


    // Start is called before the first frame update
    void Start()
    {
        SetLevel();
    }

    /*
     * Set card > Select Theme > Select Level > select card from list > Set card values..
     *            ^                  ^                  ^                    ^
     * Menu  >    ^                  ^                  ^                    ^
     *            ^ Check menu theme ^                  ^                    ^
     *                               ^ Check menu level ^                    ^
     *                                                  ^ Select random card ^
     *                                                                       ^Set card values
     */

    public void SetCard()
    {
        var cardSelectAnswer = 0;
        var cardTippText = "";
        var cardSound = game.musicSource.clip;

        // complicaded one: choose theme from value, then choose level from value, then set values for easy stack
        #region //--select card array
        switch (selectedTheme)
        {
            case 0: //favourites
                    game.targetImage.sprite = cards.fav[currentWordNumber].image;
                    cardSelectAnswer = cards.fav[currentWordNumber].rightAnswer;
                    cardTippText = cards.fav[currentWordNumber].tippText;
                    cardSound = cards.fav[currentWordNumber].sound;
                    cardFavIsOn = cards.fav[currentWordNumber].isFav;
                break;
            case 1: //time
                if (selectedLevel == 0) //A1
                {
                    game.targetImage.sprite = cards.timeA1[currentWordNumber].image;
                    cardSelectAnswer = cards.timeA1[currentWordNumber].rightAnswer;
                    cardTippText = cards.timeA1[currentWordNumber].tippText;
                    cardSound = cards.timeA1[currentWordNumber].sound;
                    cardFavIsOn = cards.timeA1[currentWordNumber].isFav;
                } else if (selectedLevel == 1)  //A2
                {
                    game.targetImage.sprite = cards.timeA2[currentWordNumber].image;
                    cardSelectAnswer = cards.timeA2[currentWordNumber].rightAnswer;
                    cardTippText = cards.timeA2[currentWordNumber].tippText;
                    cardSound = cards.timeA2[currentWordNumber].sound;
                    cardFavIsOn = cards.timeA2[currentWordNumber].isFav;
                }
                break;
            case 2: //health
                if (selectedLevel == 0) //A1
                {
                    game.targetImage.sprite = cards.healthA1[currentWordNumber].image;
                    cardSelectAnswer = cards.healthA1[currentWordNumber].rightAnswer;
                    cardTippText = cards.healthA1[currentWordNumber].tippText;
                    cardSound = cards.healthA1[currentWordNumber].sound;
                    cardFavIsOn = cards.healthA1[currentWordNumber].isFav;
                }
                else if (selectedLevel == 1)    //A2
                {
                    game.targetImage.sprite = cards.healthA2[currentWordNumber].image;
                    cardSelectAnswer = cards.healthA2[currentWordNumber].rightAnswer;
                    cardTippText = cards.healthA2[currentWordNumber].tippText;
                    cardSound = cards.healthA2[currentWordNumber].sound;
                    cardFavIsOn = cards.healthA2[currentWordNumber].isFav;
                }
                break;
        }
        #endregion

        //set answer for that card
        #region //--set card answer
        switch (cardSelectAnswer)
        {
            default:
                game.derButton.SetButtonState(false);
                game.dieButton.SetButtonState(false);
                game.dasButton.SetButtonState(false);
                break;
            case 1:
                game.derButton.SetButtonState(true);
                game.dieButton.SetButtonState(false);
                game.dasButton.SetButtonState(false);
                break;
            case 2:
                game.derButton.SetButtonState(false);
                game.dieButton.SetButtonState(true);
                game.dasButton.SetButtonState(false);
                break;
            case 3:
                game.derButton.SetButtonState(false);
                game.dieButton.SetButtonState(false);
                game.dasButton.SetButtonState(true);
                break;
        }
        #endregion

        #region //--set card tipp text
        game.tippText.text = cardTippText;
        #endregion

        #region //--add card sound
        game.musicSource.clip = cardSound;
        #endregion

        #region //--set card favourite sign
        game.favButton.isOn = cardFavIsOn;
        #endregion
    }

    private void SetLevel()
    {

    }

    public void ChangeLevelRandom()
    {
        //TOFIX:
        currentWordNumber = UnityEngine.Random.Range(0, 2);

        /*switch (selectedTheme)
        {
            default: currentWordNumber = 0; break;
            case 0: currentWordNumber = UnityEngine.Random.Range(0,cards.time.Length); break;
            case 1: currentWordNumber = UnityEngine.Random.Range(0, cards.health.Length); break;
        }*/
    }

    public void SwitchFavouriteToggle()
    {
        cardFavIsOn = game.favButton.isOn;
        if (cardFavIsOn == true)
        {
            MakeFavouritesList();
        }
    }

    public void MakeFavouritesList()
    {
        Debug.Log("//CREATING FAV LIST...");
        //WIP
        Debug.Log("//FAV LIST UPDATED");
    }
}

