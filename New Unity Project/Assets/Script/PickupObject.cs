using UnityEngine;
using System.Collections;

public class PickupObject : MonoBehaviour {
    [Range(1, 10)]
    public float shootingSpeed;
    [Range(1, 10)]
    public float distanceFromPlayer;

    private Transform player;
    private Transform holdingObjectTransform;
    private UIController uiMessage;

    private bool objectHighlighted;
    private bool holdingObject;

    void Start()
    {
        player = GetComponent<Transform>();
        uiMessage = GameObject.Find("HUD").GetComponent<UIController>();
    }
    void Update() {
        if (holdingObject)
        {
            holdingObjectTransform.position = Camera.main.transform.position + Camera.main.transform.forward * distanceFromPlayer;
            if (Input.GetMouseButtonDown(0)) Shoot(holdingObjectTransform);
            else if (Input.GetMouseButtonDown(1)) holdingObject = false;
        }
        HoldObject();
    }
    void HoldObject()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;
            if (objectHit.tag == "Interactable" && holdingObject == false)
            {
                uiMessage.DisplayText("E to interact");
                if (Input.GetKeyDown(KeyCode.E))
                {
                    holdingObject = true;
                    holdingObjectTransform = objectHit;
                }
            }
            else
                uiMessage.DisplayText("");
        }
    }
    void Shoot(Transform obj)
    {
        obj.GetComponent<Rigidbody>().velocity = Camera.main.transform.forward * shootingSpeed;
        holdingObject = false; 
    }
}
