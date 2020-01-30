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
        Debug.Log("Загадайте ваше число");
        Debug.Log("Минимальное число: " + minNumbers);
        Debug.Log("Максмальное число: " + maxNumbers);
        result = minNumbers * maxNumbers / 2;
        Debug.Log("Твое число: " + result + " ?");
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && result < 1000)
        {
            result = result + 250;
            Debug.Log("Может твое число: " + result + " ?");
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow)  && result > 1)
        {
            result = result - 250;
            Debug.Log("Может твое число: " + result + " ?");
        }

        else if (Input.GetKeyDown(KeyCode.Return) || (Input.GetKeyDown(KeyCode.KeypadEnter)))
        {
            Debug.Log("Изи, твое число: " + result);
        }
        
        
    }
}
