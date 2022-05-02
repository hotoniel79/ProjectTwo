using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Manager : MonoBehaviour
{
    //The amount of questions you will have
    [SerializeField] private GameObject[] Questions;

    //Stores what question player is in
    [SerializeField] private int CurrentQuestion;

    //The amount of points you got from the correct answers
    [SerializeField] private int CorrectPoints;

    [SerializeField] private TextMeshProUGUI PointAnnouncement;


    private void Start()
    {
        CorrectPoints = 0;
    }

    private void Update()
    {
        PointAnnouncement.text = "You got "+CorrectPoints+"/2 Answers correct";
    }


    public void NextQuestion()
    {
        //Checks if its the last question
        if(CurrentQuestion + 1 != Questions.Length)
        {
            Questions[CurrentQuestion].SetActive(false);

            CurrentQuestion++;

            Questions[CurrentQuestion].SetActive(true);

        }
    }

    public void CorrectAnswer()
    {
        CorrectPoints++;    
    }

    //What I want to do now is to to create the screen for the last question in the trivia. It is supposed to announce how many points
    //you got from correct and wrong answers

    
}
