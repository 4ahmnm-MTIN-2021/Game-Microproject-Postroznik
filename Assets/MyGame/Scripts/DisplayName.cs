using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayName : MonoBehaviour
{
    public PlayerName newPlayerName;
    private void Start()
    {
        gameObject.GetComponent<Text>().text = newPlayerName.runtimevalue;
    }
}
