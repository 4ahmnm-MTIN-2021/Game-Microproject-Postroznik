using UnityEngine;
using UnityEditor;
using System;

    [CreateAssetMenu] //object can be created in the asset menu
    public class PlayerName : ScriptableObject, ISerializationCallbackReceiver
    {
        public string runtimevalue; //this value changes while game is played
        public string initialvalue;
        public void OnBeforeSerialize()
        {
            
        }
        public void OnAfterDeserialize() //reset value when game is ended
        {
            runtimevalue = initialvalue; 
        }
    }