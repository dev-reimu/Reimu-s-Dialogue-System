using System;
using TMPro;
using UnityEngine;

public class ReimusDialogueSystem : MonoBehaviour
{
    [Serializable]
    public struct Speaker
    {
        public string name;

        int currentLine;

        [Serializable]
        public struct Line
        {
            public string text;

            [Serializable]
            public struct Rules
            {

            }
            public Rules[] perCharacterRules;
        }
        public Line[] lines;

        [Tooltip("Per character delay in tenths of a second (delay = 1 => 0.1 seconds). First element of the list refers to the first character of the line text. Second element refers to the second character. And so on and so forth.")]
        public ushort[] delay;
    }

    [SerializeField] Speaker[] dialogue;

    TextMeshPro text;
    void Start() => text = GetComponent<TextMeshPro>();

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }
}
