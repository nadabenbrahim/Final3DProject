using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizButtons : MonoBehaviour
{
    //preguntar como puedo hacerlo fijo en lugar de que sea serialized
    [SerializeField] AudioSource soundBonus;
    [SerializeField] AudioSource soundLost;

    static  int points = 0;
    

    //next buttons
    public void nextA1()
    {
        SceneManager.LoadScene("Question2");
    }

    public void nextA2()
    {
        SceneManager.LoadScene("Question3");
    }

    public void nextA3()
    {
        SceneManager.LoadScene("Question4");
    }

    public void nextA4()
    {
        SceneManager.LoadScene("Question5");
    }

    //question 1 options
    public void q1_a()
    {
        SceneManager.LoadScene("Answer1");
        QuizButtons.points += 1;
        
        soundBonus.Play();
        Debug.Log("se sumo punto! ");
        Debug.Log(QuizButtons.points);

    }

    public void q1_b()
    {
        SceneManager.LoadScene("Answer1");
        soundLost.Play();


    }

    public void q1_c()
    {
        SceneManager.LoadScene("Answer1");
        soundLost.Play();


    }

    //q2 options

    public void q2_a()
    {
        SceneManager.LoadScene("Answer2");
        soundLost.Play();


    }

    public void q2_b()
    {
        SceneManager.LoadScene("Answer2");
        QuizButtons.points += 1;

        soundBonus.Play();
        Debug.Log("se sumo punto! ");
        Debug.Log(QuizButtons.points);

    }

    //q3

    public void q3_a()
    {
        SceneManager.LoadScene("Answer3");
        QuizButtons.points += 1;

        soundBonus.Play();
        Debug.Log("se sumo punto! ");
        Debug.Log(QuizButtons.points);

    }

    public void q3_b()
    {
        SceneManager.LoadScene("Answer3");
        soundLost.Play();


    }
    //q4

    public void q4_a()
    {
        SceneManager.LoadScene("Answer4");
        QuizButtons.points += 1;

        soundBonus.Play();
        Debug.Log("se sumo punto! ");
        Debug.Log(QuizButtons.points);

    }

    public void q4_b()
    {
        SceneManager.LoadScene("Answer4");
        soundLost.Play();


    }

    public void q4_c()
    {
        SceneManager.LoadScene("Answer4");
        soundLost.Play();


    }

    //q5

    public void q5_a()
    {
        SceneManager.LoadScene("Answer5");
        soundLost.Play();


    }

    public void q5_b()
    {
        SceneManager.LoadScene("Answer5");
        QuizButtons.points += 1;

        soundBonus.Play();
        Debug.Log("se sumo punto! ");
        Debug.Log(QuizButtons.points);


    }

    public void q5_c()
    {
        SceneManager.LoadScene("Answer5");
        soundLost.Play();


    }

    public void seeScores()
    {
        if (points == 0)
        {
            SceneManager.LoadScene("Scores0");
        }
        else if ( points == 1){
            SceneManager.LoadScene("Scores1");
        }
        else if( points == 2){
            SceneManager.LoadScene("Scores2");
        }
       
        else if (points == 3){
            SceneManager.LoadScene("Scores3");
        }

        else if (points == 4)
        {
            SceneManager.LoadScene("Scores4");
        }

        else if (points == 5)
        {
            SceneManager.LoadScene("Scores5");
        }


    }


    public void PlayQuiz()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

    }

    public void QuitQuiz()
    {
        Debug.Log("EXIT!");
        SceneManager.LoadScene("MainMenuScene");

    }
}


