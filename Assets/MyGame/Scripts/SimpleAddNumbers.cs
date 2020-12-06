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
        result = int.Parse(input1.text) + int.Parse(input2.text); //converting strings to ints and adding the ammount that has been given to the input fields
        GameObject resulttext = resultButton.gameObject.transform.GetChild(0).gameObject; //get the child of the buttonobject (textfield)
        resulttext.GetComponent<Text>().text = result.ToString(); //Display result in the textfield
        resultButton.interactable = false; //deactivate button after onclick
    }
}
