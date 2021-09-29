using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashcardsManager : MonoBehaviour
{
    [SerializeField] public favCards[] fav;
    [SerializeField] public timeCardsA1[] timeA1;
    [SerializeField] public timeCardsA2[] timeA2;
    [SerializeField] public healthCardsA1[] healthA1;
    [SerializeField] public healthCardsA2[] healthA2;

    private void Awake()
    {
        //WIP load info about card lists from memory
    }
}

/*
 * FLASHCARDS LAYOUT
 *  
 * Every cards category divided to its own list, each list have values for sorting cards, info about card, answers etc.
 * cardID is unique for all lists, need to help find  
 * card level represents level A1,A2, etc
 * right answer represents answer for card: 1 - der, 2 - die, 3 - das
 * isSolved shows if that card was solved(clears after game end)
 * isFav shows if cards was marked as Favourite for proper category
 * tipp text is WIP, but uniqe for each card
 * Image and sound placed in their positions
 */

[Serializable]
public class favCards
{
    public int cardId;
    public string cardName;
    public int rightAnswer;  //1,2,3
    public bool isFav;
    public string tippText = "";
    public Sprite image;
    public AudioClip sound;
}

[Serializable]
public class timeCardsA1
{
    public int cardId;
    public string cardName;
    public int rightAnswer;  //1,2,3
    public bool isFav;
    public string tippText = "";
    public Sprite image;
    public AudioClip sound;
}

[Serializable]
public class timeCardsA2
{
    public int cardId;
    public string cardName;
    public int rightAnswer;  //1,2,3
    public bool isFav;
    public string tippText = "";
    public Sprite image;
    public AudioClip sound;
}

[Serializable]
public class healthCardsA1
{
    public int cardId;
    public string cardName;
    public int rightAnswer;  //1,2,3
    public bool isFav;
    public string tippText = "";
    public Sprite image;
    public AudioClip sound;
}

[Serializable]
public class healthCardsA2
{
    public int cardId;
    public string cardName;
    public int rightAnswer;  //1,2,3
    public bool isFav;
    public string tippText = "";
    public Sprite image;
    public AudioClip sound;
}

