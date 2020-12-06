using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleAddNumbers : MonoBehaviour
{
    public InputField input1;
    public InputField input2;
    public int result;
    public Button resultButton;
    public void CalculateResult()
    {
        result = int.Parse(input1.text) + int.Parse(input2.text);
        GameObject resulttext = resultButton.gameObject.transform.GetChild(0).gameObject;
        resulttext.GetComponent<Text>().text = result.ToString();
        resultButton.interactable = false;
    }
}
