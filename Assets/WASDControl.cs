﻿using UnityEngine;
using System.Collections;

public class WASDControl : MonoBehaviour {

    private CharacterController controller;
    private float speedFactor = 2f;

    public float getSpeedFactor()
    {
        return (speedFactor*Time.deltaTime);
    }
    
    // Use this for initialization
    void Start () {
        controller = GetComponent<CharacterController>();
	}

	// Update is called once per frame
	void Update () {
        if (Input.GetKey("w"))
        {
            Vector3 front = Camera.main.transform.forward;
            controller.Move(new Vector3(front.x, 0, front.z) * getSpeedFactor());
        }
        else if (Input.GetKey("a"))
        {
            Vector3 left = -Camera.main.transform.right;
            controller.Move(new Vector3(left.x, 0, left.z) * getSpeedFactor());
        }
        else if (Input.GetKey("s"))
        {
            Vector3 back = -Camera.main.transform.forward;
            controller.Move(new Vector3(back.x, 0, back.z) * getSpeedFactor());
        }
        else if (Input.GetKey("d"))
        {
            Vector3 right = Camera.main.transform.right;
            controller.Move(new Vector3(right.x, 0, right.z) * getSpeedFactor());
        }
    }
}
