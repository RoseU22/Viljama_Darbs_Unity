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

    public void mainaTelu(int skaitlis)
    {
        if (skaitlis == 0)
            changingImg.GetComponent<Image>().sprite = imgArr[0];
        else
            changingImg.GetComponent<Image>().sprite = imgArr[1];
    }
    public void mainaPlatumu()
    {
        float vertibaW = sliderW.GetComponent<Slider>().value;
        changingImg.transform.localScale = new Vector3(1F, 1F*vertibaW,1);
    }
    public void mainaAugstumu()
    {
        float vertibaH = sliderH.GetComponent<Slider>().value;
        changingImg.transform.localScale = new Vector3(1F * vertibaH, 1F , 1);
    }

}
