using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIMessaging : MonoBehaviour {
    private GameObject panel;
    private Text displayedText;

    void Start()
    {
        panel = GameObject.Find("TextDisplay");
        displayedText = panel.GetComponentInChildren<Text>();
        if (displayedText == null) Debug.LogError("Can't find GUIText");
        panel.SetActive(false);
    }
    public void DisplayText(string text)
    {
        if (text == "") panel.SetActive(false);
        else panel.SetActive(true);
        displayedText.text = text;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.T))
        {
            DisplayText("Hello world");
        }else
        {
            DisplayText("");
        }
    }
}
