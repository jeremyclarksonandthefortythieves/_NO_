using UnityEngine;
using System.Collections;

public class Socket : MonoBehaviour {
    [SerializeField][Range(0, 1)] private float gravityStrength = 0.5f; 
    private GameObject player;
    private Vector3 normalGravity;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        normalGravity = Physics.gravity;
    }
    void OnCollisionEnter(Collision collider)
    {
        if (collider.transform.tag == "Interactable") ; 
    }
}
