using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicNumbers : MonoBehaviour
{
    int minNumbers = 1;
    int maxNumbers = 1000;
    int result;
    int courses;


    void Start()
    {
        Debug.Log("Добро пожаловать в Magic Numbers");
        StartGame();
    }
    //Start
    private void StartGame()
    {
        courses = 0;
        minNumbers = 1;
        maxNumbers = 1000;
        Debug.Log("Загадайте ваше число");
        Debug.Log("Минимальное число: " + minNumbers);
        Debug.Log("Максмальное число: " + maxNumbers);
        UpdateResult();
    }

    //Calculation
    private void UpdateResult()
    {
        result = (minNumbers + maxNumbers) / 2;
        Debug.Log("Твое число: " + result + " ?");
    }

    void Update()
    {
        //Input up
        if (Input.GetKeyDown(KeyCode.UpArrow) && result < 1000)
        {
            courses++;
            minNumbers = result;
            UpdateResult();
        }
        //Input down
        else if (Input.GetKeyDown(KeyCode.DownArrow)  && result > 1)
        {
            courses++;
            maxNumbers = result;
            UpdateResult();
        }
        //Input enter
        else if (Input.GetKeyDown(KeyCode.Return) || (Input.GetKeyDown(KeyCode.KeypadEnter)))
        {
            courses++;
            Debug.Log("Изи, твое число: " + result);
            Debug.Log("Ты потратил " + courses + " ходов");
        }
        //Reset game
        else if (Input.GetKeyDown (KeyCode.R))
        {
            StartGame();
        }
    }
}
