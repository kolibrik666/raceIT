using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CarLight : MonoBehaviour
{
	public Renderer brakelights;
	public Material brakelightON;
	public Material brakelightOFF;

	public Renderer rearlights;
	public Material rearlightsON;
	public Material rearlightsOFF;

	public Renderer headlights;
	public Material headlightsON;
	public Material headlightsOFF;

	public Light spotlightLEFT;
	public Light spotlightRIGHT;

	void Update()
	{
		//ak brzdíme
		if ((Input.GetKey(KeyCode.DownArrow))|| (Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.Space)))
		{
			brakelights.material = brakelightON;
		}
		//ak nebrzdíme
		else
		{
			brakelights.material = brakelightOFF;
		}



		//predné svetlá on/off
		if (Input.GetKeyDown("1"))
		{
			rearlights.material = rearlightsON;
			headlights.material = headlightsON;	
		}
		if (Input.GetKeyDown("2"))
		{
			rearlights.material = rearlightsON;
			headlights.material = headlightsON;
			spotlightLEFT.intensity = 4f;
			spotlightRIGHT.intensity = 4f;
		}
		if (Input.GetKeyDown("3"))
		{
			rearlights.material = rearlightsOFF;
			headlights.material = headlightsOFF;
			spotlightLEFT.intensity = 0f;
			spotlightRIGHT.intensity = 0f; 
		}




	}
}
