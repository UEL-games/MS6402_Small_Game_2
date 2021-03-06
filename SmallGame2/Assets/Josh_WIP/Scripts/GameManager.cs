﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


    //This uses a singleton design pattern to create a single Game Manager object
    //This object uses DontDestroyOnLoad to survive new levels being loaded
    //By doing so it will hand around allowing levels to be loaded

	[HideInInspector]					//Don't show this in IDE
	public	int	Score;					//Game Score


	public	GameObject	ErrorPrefab;	//Link to Error Box


    public static GameManager GM;       //Using a static means we can access this without knowing the instance
    void Awake() {
        if (GM == null) {       //Check if we already have a Game Manager
            GM = this;          //If not make this one it
            DontDestroyOnLoad(GM.gameObject);       //Make this Object persists when loading scenes
            Debug.Log("Game manager active");
			InitGame ();
        } else if (GM != this) {
            Destroy(gameObject);     //If we are trying to create a second one, destroy it, there must be just one
        }
    }

	void	InitGame() {
		Score = 0;
	}

    public static void LoadLevel(int vIndex) {      //Load one of the stored levels, these must be in a Resources folder
        if (GM != null) {       //The level manager should be in the first level laoded to allow it to persist itself
            if (vIndex < SceneManager.sceneCountInBuildSettings) {
                SceneManager.LoadScene(vIndex);
                Debug.Log("Scene " + SceneManager.GetActiveScene().name + " Loaded");       //Get the scene name
            } else {
                Debug.Log("Invalid Index:" + vIndex);
            }
        } else {
            Debug.Log("Game manager not initialsed, must load in 1st Scene");       //Add this to the first level which is loaded
        }
    }

	public	static void	MessageBox(string vMessage,string vTitle="Message") {		//Display an error box in current scene, in red
		GameObject tGO=Instantiate (GM.ErrorPrefab);
		Error tError = tGO.GetComponent<Error> ();
		tError.Message = vMessage;
		tError.Colour = Color.red;
        tError.Title = vTitle;
	}

	public	static void	MessageBox(string vMessage,Color vColour, string vTitle = "Message") {		//Display an error box in current scene, using colour
		GameObject tGO=Instantiate (GM.ErrorPrefab);
		Error tError = tGO.GetComponent<Error> ();
		tError.Message = vMessage;
		tError.Colour = vColour;
        tError.Title = vTitle;
    }
}
