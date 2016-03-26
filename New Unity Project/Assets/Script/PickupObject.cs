using UnityEngine;
using System.Collections;

public class PickupObject : MonoBehaviour {
    private Transform player;
    UIController uiMessage;

    bool ObjectHighlighted;
    void Start()
    {
        player = GetComponent<Transform>();
        uiMessage = GameObject.Find("HUD").GetComponent<UIController>();
    }
    void Update() {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;
            if (objectHit.tag == "Interactable") uiMessage.DisplayText("E to interact");
            else uiMessage.DisplayText("");
        }
    }
}
