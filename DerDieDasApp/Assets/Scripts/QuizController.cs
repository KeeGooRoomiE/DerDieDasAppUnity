using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizController : MonoBehaviour
{
    public Image falseStateImage;
    public Image trueStateImage;
    [SerializeField] private Button nextQuizButton;
    [SerializeField] private Slider progressBarSlider;
    [SerializeField] private TextMeshProUGUI tippText;
    [SerializeField] private Toggle tippButton;
    [SerializeField] private Toggle favButton;
    private float progressBarCounter;
    [SerializeField] private int progressBarModifier = 10;


    // Start is called before the first frame update
    void Start()
    {
        progressBarCounter = 0f;
        progressBarSlider.value = progressBarCounter;
        progressBarSlider.maxValue = progressBarModifier;
    }

    public void setAnswer(bool isRight)
    {
        if (isRight == true)
        {
            trueStateImage.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        } else
        {
            falseStateImage.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }

        nextQuizButton.interactable = isRight;
    }

    public void ResetQuiz()
    {
        trueStateImage.color = new Color(1.0f, 1.0f, 1.0f, 0f);
        falseStateImage.color = new Color(1.0f, 1.0f, 1.0f, 0f);
        tippText.enabled = false;
        tippButton.interactable = true;
        tippButton.isOn = false;
        favButton.isOn = false;
        nextQuizButton.interactable = false;
    }

    public void UpdateProgress()
    {
        progressBarSlider.value = progressBarCounter;
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
