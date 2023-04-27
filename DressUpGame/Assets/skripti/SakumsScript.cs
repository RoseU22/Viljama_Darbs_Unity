using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class SakumsScript : MonoBehaviour {
	public void exitBtn(){
		Application.Quit();
	}
	public void mortyBtn(){
		SceneManager.LoadScene("MortyScene", LoadSceneMode.Single);
	}
	public void menu(){
		SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
	}


}
