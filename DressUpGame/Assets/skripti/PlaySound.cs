using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySound : MonoBehaviour {
	public AudioSource MSource;
	public AudioSource RSource;
	public AudioClip MClip;
	public AudioClip RClip;
	public GameObject tels;

	public void audioPlay(){
		
		if (tels.GetComponent<Dropdown>().value == 0)
			MSource.PlayOneShot (MClip);
		else
			RSource.PlayOneShot (RClip);
	}
}
