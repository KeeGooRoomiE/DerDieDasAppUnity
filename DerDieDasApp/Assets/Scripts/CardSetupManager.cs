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

        Debug.Log("//TIME A1 CARDS POOL IS " + cards.timeA1.Length + " ELEMENTS");
        Debug.Log("//HEALTH A1 CARDS POOL IS " + cards.healthA1.Length + " ELEMENTS");
        Debug.Log("//TRANSPORT A1 CARDS POOL IS " + cards.transportA1.Length + " ELEMENTS");
        Debug.Log("//CLOTHES A1 CARDS POOL IS " + cards.clothesA1.Length + " ELEMENTS");
        Debug.Log("//FOOD&DRINKS A1 CARDS POOL IS " + cards.foodA1.Length + " ELEMENTS");
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
        ChangeLevelRandom();

        var cardSelectAnswer = 0;
        var cardTippText = "";
        var cardSound = game.musicSource.clip;

        // complicaded one: choose theme from value, then choose level from value, then set values for easy stack
        #region //--select card array
        switch (selectedTheme)
        {
            case 0: //favourites
                    game.targetImage.sprite = cards.fav[currentWordNumber].image;
                    game.cardName.text = cards.fav[currentWordNumber].cardName;
                cardSelectAnswer = cards.fav[currentWordNumber].rightAnswer;
                    cardTippText = cards.fav[currentWordNumber].tippText;
                    cardSound = cards.fav[currentWordNumber].sound;
                    cardFavIsOn = cards.fav[currentWordNumber].isFav;
                break;
            case 1: //time
                if (selectedLevel == 0) //A1
                {
                    game.targetImage.sprite = cards.timeA1[currentWordNumber].image;
                    game.cardName.text = cards.timeA1[currentWordNumber].cardName;
                    cardSelectAnswer = cards.timeA1[currentWordNumber].rightAnswer;
                    cardTippText = cards.timeA1[currentWordNumber].tippText;
                    cardSound = cards.timeA1[currentWordNumber].sound;
                    cardFavIsOn = cards.timeA1[currentWordNumber].isFav;
                } else if (selectedLevel == 1)  //A2
                {
                    game.targetImage.sprite = cards.timeA2[currentWordNumber].image;
                    game.cardName.text = cards.timeA2[currentWordNumber].cardName;
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
                    game.cardName.text = cards.healthA1[currentWordNumber].cardName;
                    cardSelectAnswer = cards.healthA1[currentWordNumber].rightAnswer;
                    cardTippText = cards.healthA1[currentWordNumber].tippText;
                    cardSound = cards.healthA1[currentWordNumber].sound;
                    cardFavIsOn = cards.healthA1[currentWordNumber].isFav;
                }
                else if (selectedLevel == 1)    //A2
                {
                    game.targetImage.sprite = cards.healthA2[currentWordNumber].image;
                    game.cardName.text = cards.healthA2[currentWordNumber].cardName;
                    cardSelectAnswer = cards.healthA2[currentWordNumber].rightAnswer;
                    cardTippText = cards.healthA2[currentWordNumber].tippText;
                    cardSound = cards.healthA2[currentWordNumber].sound;
                    cardFavIsOn = cards.healthA2[currentWordNumber].isFav;
                }
                break;
            case 6: //clothes
                if (selectedLevel == 0) //A1
                {
                    game.targetImage.sprite = cards.clothesA1[currentWordNumber].image;
                    game.cardName.text = cards.clothesA1[currentWordNumber].cardName;
                    cardSelectAnswer = cards.clothesA1[currentWordNumber].rightAnswer;
                    cardTippText = cards.clothesA1[currentWordNumber].tippText;
                    cardSound = cards.clothesA1[currentWordNumber].sound;
                    cardFavIsOn = cards.clothesA1[currentWordNumber].isFav;
                }
                break;
            case 7: //transport
                if (selectedLevel == 0) //A1
                {
                    game.targetImage.sprite = cards.transportA1[currentWordNumber].image;
                    game.cardName.text = cards.transportA1[currentWordNumber].cardName;
                    cardSelectAnswer = cards.transportA1[currentWordNumber].rightAnswer;
                    cardTippText = cards.transportA1[currentWordNumber].tippText;
                    cardSound = cards.transportA1[currentWordNumber].sound;
                    cardFavIsOn = cards.transportA1[currentWordNumber].isFav;
                }
                break;
            case 10: //food & drinks
                if (selectedLevel == 0) //A1
                {
                    game.targetImage.sprite = cards.foodA1[currentWordNumber].image;
                    game.cardName.text = cards.foodA1[currentWordNumber].cardName;
                    cardSelectAnswer = cards.foodA1[currentWordNumber].rightAnswer;
                    cardTippText = cards.foodA1[currentWordNumber].tippText;
                    cardSound = cards.foodA1[currentWordNumber].sound;
                    cardFavIsOn = cards.foodA1[currentWordNumber].isFav;
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
        //Just a reminder of categories of flashcards:
        //
        // FAVS - 0
        // TIME - 1
        // HEALTH - 2
        //
        //currentWordNumber = UnityEngine.Random.Range(0, 8);
        //

        switch (selectedTheme)
        {
            default: currentWordNumber = 0;
                Debug.Log("//USED DEBUG 0 VALUE FOR SOME REASON TO PREVENT ERROR..."); break;
            case 1:
                if (selectedLevel == 0)
                {
                    Debug.Log("//SELECTED CATEGORY IS TIME A1");
                    currentWordNumber = UnityEngine.Random.Range(0, cards.timeA1.Length);
                    Debug.Log("//SELECTED CARD IS "+currentWordNumber+" OF "+cards.timeA1.Length);
                }
                break;
            case 2:
                if (selectedLevel == 0)
                {
                    Debug.Log("//SELECTED CATEGORY IS HEALTH A1");
                    currentWordNumber = UnityEngine.Random.Range(0, cards.healthA1.Length);
                    Debug.Log("//SELECTED CARD IS " + currentWordNumber + " OF " + cards.healthA1.Length);
                }
                break;
            case 6:
                if (selectedLevel == 0)
                {
                    Debug.Log("//SELECTED CATEGORY IS CLOTHES A1");
                    currentWordNumber = UnityEngine.Random.Range(0, cards.clothesA1.Length);
                    Debug.Log("//SELECTED CARD IS " + currentWordNumber + " OF " + cards.clothesA1.Length);
                }
                break;
            case 7:
                if (selectedLevel == 0)
                {
                    Debug.Log("//SELECTED CATEGORY IS TRANSPORT A1");
                    currentWordNumber = UnityEngine.Random.Range(0, cards.transportA1.Length);
                    Debug.Log("//SELECTED CARD IS " + currentWordNumber + " OF " + cards.transportA1.Length);
                }
                break;
            case 10:
                if (selectedLevel == 0)
                {
                    Debug.Log("//SELECTED CATEGORY IS FOOD&DRINKS A1");
                    currentWordNumber = UnityEngine.Random.Range(0, cards.foodA1.Length);
                    Debug.Log("//SELECTED CARD IS " + currentWordNumber + " OF " + cards.foodA1.Length);
                }
                break;
        }
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

