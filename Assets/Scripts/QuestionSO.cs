using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2,6)]
    [SerializeField] string question = "Enter new question text here";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswer;

    public string getQuestion()
    {
        return question;
    }

    public int getCorrectAnswerIndex()
    {
        return correctAnswer;
    }

    public string getCorrectAnswer(int correctIndex)
    {
        return answers[correctIndex];
    }
}
