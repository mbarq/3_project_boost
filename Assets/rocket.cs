using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour {


    Rigidbody rigidbody;
    AudioSource audioSource;
   

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {
        processInput();

		
	}

    private void processInput()
    {
        if (Input.GetKey(KeyCode.Space)) {

            rigidbody.AddRelativeForce(Vector3.up);
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }

        else
        {
            audioSource.Stop();
        }

        if (Input.GetKey(KeyCode.A)) {

            transform.Rotate(Vector3.forward);
        }

        else if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(-Vector3.forward);
        }
    }
}
