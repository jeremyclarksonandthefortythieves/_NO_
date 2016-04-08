using UnityEngine;
using System.Collections;

public class controllerTrigger : MonoBehaviour {

    public controllerBehaviour doorAnim;

    void Start() {
        doorAnim = FindObjectOfType<controllerBehaviour>();
    }
    void OnTriggerEnter(Collider other) {
        if (other.name == "Player") {
            doorAnim.anim.SetInteger("doorBehaviour", 1);
        }
    }
    void OnTriggerExit(Collider other) {
        if (other.name == "Player") {
            doorAnim.anim.SetInteger("doorBehaviour", 2);
        }
    }
}
