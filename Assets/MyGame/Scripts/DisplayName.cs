using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//this gets attached to every object that should display the name
public class DisplayName : MonoBehaviour
{
    public PlayerName newPlayerName;
    private void Start()
    {
        gameObject.GetComponent<Text>().text = newPlayerName.runtimevalue; //get the textcomponent from object and display playername
    }
}
