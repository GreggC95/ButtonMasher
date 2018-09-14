using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

    // Data for our class
    public AudioSource ClickSound; // sound that will play when the button is pressed
    public TextMesh scoreText; // display text for the players score

    private int score = 0; // the numerical data value of our score

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
        // increase the score by 1 
        score = score + 1;
        //Update visual score
        scoreText.text = score.ToString();
    }// End of OnMouseDown()





}// End of ButtonMasher Class
