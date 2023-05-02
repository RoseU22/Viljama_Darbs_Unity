using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextScript : MonoBehaviour {
	public GameObject button;
	public GameObject input1;
	public GameObject input2;
	public GameObject textField;
	public string textLine;


	public void showText(){
		textLine = "Multfilmas varonis "+(input1.GetComponent<Text>().text)+", vecums "+(input2.GetComponent<Text>().text)+" gadi!";
		textField.GetComponent<Text>().text = textLine;
	}
}
