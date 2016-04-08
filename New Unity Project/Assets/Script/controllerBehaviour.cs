using UnityEngine;
using System.Collections;

public class controllerBehaviour : MonoBehaviour {

    public Animator anim;

    void Start() {
        anim = GetComponent<Animator>();
    }
}
