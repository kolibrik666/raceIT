using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LoadLapTime : MonoBehaviour
{
	public int MinCount;
	public int SecCount;
	public float MilliCount;
	public GameObject MinDisplay;
	public GameObject SecDisplay;
	public GameObject MilliDisplay;

	void Start()
	{

		MinCount = PlayerPrefs.GetInt("MinSave");
		SecCount = PlayerPrefs.GetInt("SecSave");
		MilliCount = PlayerPrefs.GetFloat("MilliSave");

		MinDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" + MinCount + ":";
		SecDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" + SecCount + ".";
		MilliDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" + (int)Mathf.Round(LapTimeManager.MilliCount);

	}
}
