using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour {
    public GameObject iconSpritePrefab;
    private GameObject panel;
    private Text displayedText;
    private GameObject iconSprite;
    void Start()
    {
        iconSprite = Instantiate(iconSpritePrefab);
        iconSprite.transform.SetParent(transform);
        iconSprite.transform.position = new Vector3(Screen.width/2,Screen.height/2+50);
        panel = GameObject.Find("TextDisplay");
        displayedText = panel.GetComponentInChildren<Text>();
        if (displayedText == null) Debug.LogError("Can't find GUIText");
    }
    public void DisplayText(string text)
    {
        displayedText.text = text;
    }
    public void DisplayIcon(bool displayIcon)
    {
        iconSprite.gameObject.SetActive(displayIcon);
    }
}
