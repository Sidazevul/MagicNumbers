using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicNumbers : MonoBehaviour
{
    int minNumbers = 1;
    int maxNumbers = 1000;
    int result;

    
    void Start()
    {
        Debug.Log("Добро пожаловать в Magic Numbers");
        StartGame();
    }

    private void StartGame()
    {
        minNumbers = 1;
        maxNumbers = 1000;
        Debug.Log("Загадайте ваше число");
        Debug.Log("Минимальное число: " + minNumbers);
        Debug.Log("Максмальное число: " + maxNumbers);
        UpdateResult();
    }

    private void UpdateResult()
    {
        result = (minNumbers + maxNumbers) / 2;
        Debug.Log("Твое число: " + result + " ?");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && result < 1000)
        {
            minNumbers = result;
            UpdateResult();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow)  && result > 1)
        {
            maxNumbers = result;
            UpdateResult();
        }

        else if (Input.GetKeyDown(KeyCode.Return) || (Input.GetKeyDown(KeyCode.KeypadEnter)))
        {
            Debug.Log("Изи, твое число: " + result);
            StartGame();
        }
        
        
    }
}
