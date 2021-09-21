using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerButtonState : MonoBehaviour
{
    [SerializeField] private QuizController controller;
    [SerializeField] private bool answerState;

    public void SetAnswerAttempt()
    {
        controller.setAnswer(answerState);
    }

    public void SetButtonState(bool isRight)
    {
        answerState = isRight;
    }
}
