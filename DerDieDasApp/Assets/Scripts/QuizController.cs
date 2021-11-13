using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizController : MonoBehaviour
{
    //public Image falseStateImage;
    public Image reactionImage;
    [SerializeField] private Sprite trueSprite;
    [SerializeField] private Sprite falseSprite;
    [SerializeField] private AudioSource reactionSource;
    [SerializeField] private AudioClip trueAudio;
    [SerializeField] private AudioClip falseAudio;
    public Slider progressBarSlider;
    public Image targetImage;
    public TextMeshProUGUI cardName;
    public AnswerButtonState derButton;
    public AnswerButtonState dieButton;
    public AnswerButtonState dasButton;
    public Toggle tippButton;
    public TextMeshProUGUI tippText;
    public Toggle favButton;
    public Button nextQuizButton;
    public AudioSource musicSource;
    public GameObject popup;
    private float progressBarCounter;
    [SerializeField] private int progressBarModifier = 10;
    private bool isPopupAppeared = false;


    // Start is called before the first frame update
    void Start()
    {
        RestartProgress();
    }

    public void setAnswer(bool isRight)
    {
        if (isRight == true)
        {
            reactionImage.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            reactionImage.sprite = trueSprite;
            reactionSource.clip = trueAudio;
            //falseStateImage.color = new Color(1.0f, 1.0f, 1.0f, 0f);
        } else
        {
            reactionImage.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            reactionImage.sprite = falseSprite;
            reactionSource.clip = falseAudio;
            //falseStateImage.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }

        reactionSource.Play();
        nextQuizButton.interactable = isRight;
    }

    public void ResetQuiz()
    {
        reactionImage.color = new Color(1.0f, 1.0f, 1.0f, 0f);
        //falseStateImage.color = new Color(1.0f, 1.0f, 1.0f, 0f);
        tippButton.interactable = true;
        tippButton.isOn = false;
        favButton.isOn = false;
        tippText.enabled = false;
        nextQuizButton.interactable = false;
    }

    public void UpdateProgress()
    {
        progressBarSlider.value = progressBarCounter;
    }

    public void RestartProgress()
    {
        progressBarCounter = 0f;
        progressBarSlider.value = progressBarCounter;
        progressBarSlider.maxValue = progressBarModifier;
    }

    public void Update()
    {
        if (progressBarSlider.value == progressBarSlider.maxValue)
        {
            if (isPopupAppeared == false)
            {
                popup.SetActive(true);
                isPopupAppeared = true;
            }
        }
    }

    public void RestartPopup()
    {
        isPopupAppeared = false;
    }

    public void IncrementProgress()
    {
        progressBarCounter += 1;
        UpdateProgress();
    }

    public void DecrementProgress()
    {
        progressBarCounter -= 1;
        UpdateProgress();
    }
}
