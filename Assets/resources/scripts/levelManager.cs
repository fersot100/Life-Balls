﻿using UnityEngine;
using System.Collections;

public class levelManager : MonoBehaviour {


	public AsyncOperation asyc;
	public bool levelSwitch = false;
	
	// Use this for initialization
	
	void Start()
	{
		
	}
	
	public void begin () {
        Application.LoadLevel("Start");
	}
	
	// Update is called once per frame
	public void game (string level) {
        Application.LoadLevel(level);
    }

   public void quitGame() {
        Application.Quit();

    }
    
  
    
}
