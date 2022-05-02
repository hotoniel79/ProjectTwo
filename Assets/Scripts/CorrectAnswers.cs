using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CorrectAnswers : MonoBehaviour
{
    //[SerializeField] private int AnswerPoints;

    //[SerializeField] private int WrongAnswerPoints;

    [SerializeField] Button Button;

    //[SerializeField] private TextMeshProUGUI PlayerHPTEXT;

    //COLORS FOR THE CORRECT AND WRONG ANSWERS
    [SerializeField] private Color CorrectColor;

    [SerializeField] private Color WrongColor;


    //The questions are the levels
    //[SerializeField] private GameObject[] Questions;

    //Stores what question player is in
    //[SerializeField] private int CurrentQuestion; 


    void Update()
    {
        
    }

    public void CorrectAnswer()
    {
        ColorBlock cb = Button.colors;
        cb.pressedColor = CorrectColor;

        /*
        if (CurrentQuestion + 1 != Questions.Length)
        {
            Questions[CurrentQuestion].SetActive(false);

            CurrentQuestion++;

            Questions[CurrentQuestion].SetActive(true);
        }
        */
    }

    public void WrongAnswer()
    {
        ColorBlock cb = Button.colors;
        cb.pressedColor = WrongColor;
    }
}
