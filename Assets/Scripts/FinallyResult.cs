using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinallyResult : MonoBehaviour
{
    public Text finallyText;
    // Start is called before the first frame update
    void Start()
    {
        MagicNumbersUI manager = FindObjectOfType<MagicNumbersUI>();
        int number = manager.result;
        finallyText.text = $"Твое число: {number}";

        Destroy(manager.gameObject);
    }

  
}
