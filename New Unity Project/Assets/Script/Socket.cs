using UnityEngine;
using System.Collections;

public class Socket : MonoBehaviour {
    [SerializeField][Range(0, 1)] private float gravityStrength = 0.5f; 
    private GameObject player;
    private Vector3 normalGravity;
    private bool active;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        normalGravity = Physics.gravity;
    }
    void Update()
    {
        if (active) Physics.gravity = normalGravity*gravityStrength;
        else Physics.gravity = normalGravity;
    }
    void OnCollisionEnter(Collision collider)
    {
        if (collider.transform.tag == "Interactable") active = true; 
    }
    void OnCollisionExit(Collision collider)
    {
        if (collider.transform.tag == "Interactable") active = false;
    }
}
