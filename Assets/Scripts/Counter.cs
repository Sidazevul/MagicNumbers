using UnityEngine;

public class Counter : MonoBehaviour
{
    static int result = 0;
    static int steps = 0;

    void Start()
    {
        Debug.Log("Введите число");
    }

    void Update()
    {
        Calculate();
        EndGame();
        ResetGame();
    }

    private void ResetGame()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Введите число");
            result = 0;
        }
    }

    private void Calculate()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            steps++;
            result += 1;
            Debug.Log("Ваше число: " + result);
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            steps++;
            result += 2;
            Debug.Log("Ваше число: " + result);
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            steps++;
            result += 3;
            Debug.Log("Ваше число: " + result);
        }

        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            steps++;
            result += 4;
            Debug.Log("Ваше число: " + result);
        }

        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            steps++;
            result += 5;
            Debug.Log("Ваше число: " + result);
        }

        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            steps++;
            result += 6;
            Debug.Log("Ваше число: " + result);
        }

        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            steps++;
            result += 7;
            Debug.Log("Ваше число: " + result);
        }

        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            steps++;
            result += 8;
            Debug.Log("Ваше число: " + result);
        }

        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            steps++;
            result += 9;
            Debug.Log("Ваше число: " + result);
        }
        
        

    }

    private static void EndGame()
    {
        if (result >= 50)
        {
            Debug.Log("Количество ходов: " + steps);
            Debug.Log("Игра завершена");
        }
    }

}