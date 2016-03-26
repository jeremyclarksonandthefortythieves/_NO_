using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour {
    private GameObject panel;
    private Text displayedText;

    void Start()
    {
        panel = GameObject.Find("TextDisplay");
        displayedText = panel.GetComponentInChildren<Text>();
        if (displayedText == null) Debug.LogError("Can't find GUIText");
    }
    public void DisplayText(string text)
    {
        displayedText.text = text;
    }
}
