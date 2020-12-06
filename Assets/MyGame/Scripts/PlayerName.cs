using UnityEngine;
using UnityEditor;
using System;




    [CreateAssetMenu]
    public class PlayerName : ScriptableObject, ISerializationCallbackReceiver
    {
        public string runtimevalue;
        public string initialvalue;
        public void OnBeforeSerialize()
        {
            
        }
        public void OnAfterDeserialize()
        {
            runtimevalue = initialvalue;
        }
    }