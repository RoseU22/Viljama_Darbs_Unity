using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class SakumsScript : MonoBehaviour {
	public GameObject Play;
	public GameObject Exit;
	public GameObject MortyBtn;
	public GameObject RickBtn;
	public GameObject Back;

	public void playBtn(){
		Play.SetActive (false);
		Exit.SetActive (false);
		Back.SetActive (true);
		MortyBtn.SetActive (true);
		RickBtn.SetActive (true);
	}
	public void backBtn(){
		Play.SetActive (true);
		Exit.SetActive (true);
		Back.SetActive (false);
		MortyBtn.SetActive (false);
		RickBtn.SetActive (false);
	}
	public void exitBtn(){
		Application.Quit();
	}
	public void mortyBtn(){
		SceneManager.LoadScene("MortyScene", LoadSceneMode.Single);
	}
	public void rickBtn(){
		SceneManager.LoadScene("RickScene", LoadSceneMode.Single);
	}
	public void menu(){
		SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
	}


}
