using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;

public class RaceFinish : MonoBehaviour
{
	public PositionManager posManager;

	public GameObject UIFinish;
	public GameObject Button;
	public GameObject First;
	public GameObject Second;
	public GameObject Third;
	public GameObject Fourth;

	public GameObject[] MyCar;
	public GameObject[] CamParent;
	public GameObject AICar;
	public GameObject PosDisplay;
	public GameObject LapDisplay;
	public EscButton EscButton;

	public GameObject FinishCam;
	public AudioSource LevelMusic;
	public GameObject CompleteTrig;	
	public GameObject SpeedParent;

	public CarAIControl ScriptCarAI;
	public LapTimeManager ScriptLapTime;

	public int MoneyReward;
	public int RepReward;

	void OnTriggerEnter()
	{

		this.GetComponent<BoxCollider>().enabled = false;
		
		CompleteTrig.SetActive(false);
		for (int i = 0; i < MyCar.Length; i++)
		{
			MyCar[i].SetActive(false);
			CamParent[i].SetActive(false);
		}

		FinishCam.SetActive(true);
		LevelMusic.volume = 0.4f;
		AICar.SetActive(false);
		PosDisplay.SetActive(false);
		LapDisplay.SetActive(false);
		SpeedParent.SetActive(false);
		LevelMusic.volume=0.4f;
		EscButton.enabled = false;
		ScriptLapTime.enabled = false;
		LapTimeManager.MilliDisplay = "0";

		if (posManager.currentPos == 1)
		{
			GlobalCurrency.TotalMoney += MoneyReward;
			PlayerPrefs.SetInt("SavedMoney", GlobalCurrency.TotalMoney);
			GlobalCurrency.TotalRespect += RepReward;
			PlayerPrefs.SetInt("SavedRespect", GlobalCurrency.TotalRespect);
		}
        else {
			PlayerPrefs.SetInt("SavedMoney", GlobalCurrency.TotalMoney);
			PlayerPrefs.SetInt("SavedRespect", GlobalCurrency.TotalRespect);
		}
		 

		Finishtext();
		
	}

	public void Finishtext()
    {
		UIFinish.SetActive(true); 
		if (posManager.currentPos == 1)
		{
			First.SetActive(true);
		}
		if (posManager.currentPos == 2)
		{
			Second.SetActive(true);
		}
		if (posManager.currentPos == 3)
		{
			Third.SetActive(true);
		}
		if (posManager.currentPos == 4)
		{
			Fourth.SetActive(true);
		}

		Button.SetActive(true);
	}
	
	
}
