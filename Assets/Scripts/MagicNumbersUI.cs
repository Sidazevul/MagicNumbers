using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicNumbersUI : MonoBehaviour
{
    public int minNumbers = 1;
    public int maxNumbers = 1001;
    public Text Counter;
    public Text Courses;
    public int result;
    int CoursesNumb = 0;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        GenerateNumber();
    }

    public void GetInputUp()
    {
        GenerateSteps();
        minNumbers = result;
        GenerateNumber();
    }

    public void GetInputDown()
    {
        GenerateSteps();
        maxNumbers = result;
        GenerateNumber();
    }

    private void GenerateSteps()
    {
        CoursesNumb++;
        Courses.text = $"Steps taken: {CoursesNumb}";
    }
    private void GenerateNumber()
    {
        result = Random.Range(minNumbers, maxNumbers + 1);
        Counter.text = $"Your number \n {result}";
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
