using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

    // Data for our class
    public AudioSource ClickSound; // sound that will play when the button is pressed


	// Use this for initialization
	void Start () {
        Debug.Log("Start method called");
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Update");
    }// End of Update()

    //Responds to event from Unity that the object has been clicked
    void OnMouseDown()
    {
        Debug.Log("OnMouseDown method called");
        //Trigger our clicking sound to play
        ClickSound.Play();
    }// End of OnMouseDown()



}// End of ButtonMasher Class
