using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class SakumsScript : MonoBehaviour {
	public GameObject Play;
	public GameObject Exit;
	public GameObject dropdown;
	public GameObject Rick;
	public GameObject Morty;


	public void playBtn(){
		mortyBtn ();
	}
	public void mainaTelu (int indekss){
		if (indekss == 0) {
			Rick.SetActive (false);
			Morty.SetActive (true);
		}
		if (indekss == 1) {
			Rick.SetActive (true);
			Morty.SetActive (false);
		}
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
