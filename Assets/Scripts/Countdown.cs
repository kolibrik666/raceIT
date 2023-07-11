using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;
public class Countdown : MonoBehaviour
{
	public GameObject CountDown;
	public AudioSource GetReady;
	public AudioSource GoAudio;
	public GameObject LapTimer;
	public InputController InputControllerScript;
	public CarAIControl CarAIControlScript;
	public AudioSource LevelMusic;
	void Start()
	{
		StartCoroutine(CountStart());
	}


	IEnumerator CountStart()
	{
		yield return new WaitForSeconds(0.5f);
		CountDown.GetComponent<TMPro.TextMeshProUGUI>().text = "3";
		GetReady.Play();
		CountDown.SetActive(true);
		yield return new WaitForSeconds(1);
		CountDown.SetActive(false);
		CountDown.GetComponent<TMPro.TextMeshProUGUI>().text = "2";
		GetReady.Play();
		CountDown.SetActive(true);
		yield return new WaitForSeconds(1);
		CountDown.SetActive(false);
		CountDown.GetComponent<TMPro.TextMeshProUGUI>().text = "1";
		GetReady.Play();
		CountDown.SetActive(true);
		yield return new WaitForSeconds(1);
		CountDown.SetActive(false);
		GoAudio.Play();
		LevelMusic.Play();
		LapTimer.SetActive(true);
		InputControllerScript.enabled = true;
		CarAIControlScript.enabled = true;

	}



}
