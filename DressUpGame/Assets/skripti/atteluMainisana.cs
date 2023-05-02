using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class atteluMainisana : MonoBehaviour {
	public GameObject changingImg; 
    public Sprite[] imgArr;
    public GameObject sliderW;
    public GameObject sliderH;
	public float vertibaW;
	public float vertibaH;

	public GameObject hat1Img;
	public GameObject hat2Img;
	public GameObject shirt1Img;
	public GameObject shirt2Img;
	public GameObject pants1Img;
	public GameObject pants2Img;
	public GameObject Text1;

    public void mainaTelu(int skaitlis)
    {
        if (skaitlis == 0)
            changingImg.GetComponent<Image>().sprite = imgArr[0];
        else
            changingImg.GetComponent<Image>().sprite = imgArr[1];
		
    }
    public void mainaPlatumu()
    {
        vertibaW = sliderW.GetComponent<Slider>().value;
		vertibaH = sliderH.GetComponent<Slider>().value;
		changingImg.transform.localScale = new Vector3(vertibaH, 1F*vertibaW,1);
    }
    public void mainaAugstumu()
    {
        vertibaH = sliderH.GetComponent<Slider>().value;
		vertibaW = sliderW.GetComponent<Slider>().value;
		changingImg.transform.localScale = new Vector3(1F * vertibaH, vertibaW , 1);
    }
	public void hat1Attels(bool vertiba){
		hat1Img.SetActive (vertiba);

	}
	public void hat2Attels(bool vertiba){
		hat2Img.SetActive (vertiba);

	}
	public void shirt1Attels(bool vertiba){
		shirt1Img.SetActive (vertiba);
	}
	public void shirt2Attels(bool vertiba){
		shirt2Img.SetActive (vertiba);
	}
	public void pants1Attels(bool vertiba){
		pants1Img.SetActive (vertiba);

	}
	public void pants2Attels(bool vertiba){
		pants2Img.SetActive (vertiba);
	}
}
