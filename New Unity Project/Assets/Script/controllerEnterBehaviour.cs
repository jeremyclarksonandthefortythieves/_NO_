﻿using UnityEngine;
using System.Collections;

public class controllerEnterBehaviour : MonoBehaviour {

    public controllerBehaviour doorAnim;
	public GameObject particles1;
	public GameObject particles2;
	public Light light;
	private float fading = 0f;
	public float fadeRate = 10f;
	public float fadeTo = 2f;
	private bool lightStart = false;

    void Start()
    {
        doorAnim = FindObjectOfType<controllerBehaviour>();
    }

	void Update()
	{
		if (lightStart) {
			fading += Time.deltaTime * fadeRate;
			light.intensity = Mathf.Lerp (.2f,fadeTo,fading);
		}
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            doorAnim.anim.SetInteger("doorBehaviour", 2);
			particles1.SetActive (false);
			particles2.SetActive (true);
			lightStart = true;
        }
    }
}
