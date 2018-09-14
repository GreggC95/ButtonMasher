using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

    // Data for our class
    public AudioSource ClickSound; // sound that will play when the button is pressed
    public TextMesh scoreText; // display text for the players score
    public TextMesh TimerText; // display text for the Time remaining
    public float gameLength; // how many seconds the game will last

    private int score = 0; // the numerical data value of our score
    private float timeRemaining = 0; // Numerical Time remaining for our timer
    private bool gameRunning = true;


	// Use this for initialization
	void Start () {
        Debug.Log("Start method called");

        timeRemaining = gameLength; 

    }//end of start()
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Update");
        // Update the numerical time remaining
        timeRemaining = timeRemaining - Time.deltaTime;

        //Update the visual time remaining
        TimerText.text = (Mathf.CeilToInt(timeRemaining)).ToString();

        //chrck if we have run out of time
        if (timeRemaining <= 0)
        {
            gameRunning = false;

            //stop our time from going negative
            timeRemaining = 0;
        }// end of if (timeRunning <= 0)

    }// End of Update()

    //Responds to event from Unity that the object has been clicked
    void OnMouseDown()
    {
        Debug.Log("OnMouseDown method called");

        // check if the game is still running...
        if (gameRunning == true)
        {
            //Trigger our clicking sound to play
            ClickSound.Play();
            // increase the score by 1 
            score = score + 1;
            //Update visual score
            scoreText.text = score.ToString();
        }// End of if (gameRunning == true)

    }// End of OnMouseDown()





}// End of ButtonMasher Class
