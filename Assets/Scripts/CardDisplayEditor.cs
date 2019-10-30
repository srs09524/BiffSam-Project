using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CardDisplay))]
public class CardDisplayEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        CardDisplay myScript = (CardDisplay)target;
        if (GUILayout.Button("Reload Card"))
        {
            myScript.LoadCard();
        }
    }
}