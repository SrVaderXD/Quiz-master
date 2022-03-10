using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;
    public bool loadNextQuestion;
    public float fillFraction;
    public bool isAnsweringQuestion;
    float currentTimerValue;

    void Update()
    {
        updateTimer();
    }

    public void cancelTimer()
    {
        currentTimerValue = 0;
    }

    void updateTimer()
    {
        currentTimerValue -= Time.deltaTime;

        if(isAnsweringQuestion)
        {
            if(currentTimerValue > 0)
            {
                fillFraction = currentTimerValue / timeToCompleteQuestion;
            }
            else
            {
                isAnsweringQuestion = false;
                currentTimerValue = timeToShowCorrectAnswer;
            }
        }
        else
        {
            if(currentTimerValue > 0)
            {
                fillFraction = currentTimerValue / timeToShowCorrectAnswer;
            }
            else
            {
                isAnsweringQuestion = true;
                currentTimerValue = timeToCompleteQuestion;
                loadNextQuestion = true;
            }
        }
    }
}
