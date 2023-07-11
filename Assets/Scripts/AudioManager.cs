using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string MusicPref = "MusicPref";
    private static readonly string FXPref = "FXPref";
    private static readonly string EnginePref = "EnginePref";
    private int FirstPlayInt;
    public Slider musicSlider, FXSlider, engineSlider;
    private float musicFloat, FXFloat, engineFloat;
    public AudioSource musicAudio;
    public AudioSource[] engineAudio;
    public AudioSource[] FXAudio;
    
    void Start()
    {
        FirstPlayInt = PlayerPrefs.GetInt(FirstPlay);

        if(FirstPlayInt == 0)
        {
            musicFloat = .25f;
            FXFloat = .75f;
            engineFloat = .75f;
            musicSlider.value = musicFloat;
            FXSlider.value = FXFloat;
            engineSlider.value = engineFloat;
            PlayerPrefs.SetFloat(MusicPref, musicFloat);
            PlayerPrefs.SetFloat(FXPref, FXFloat);
            PlayerPrefs.SetFloat(EnginePref, engineFloat);
            PlayerPrefs.SetInt(FirstPlay, -1);
        }
        else
        {
           musicFloat = PlayerPrefs.GetFloat(MusicPref);
            musicSlider.value = musicFloat;
            FXFloat = PlayerPrefs.GetFloat(FXPref);
            FXSlider.value = FXFloat;
            engineFloat = PlayerPrefs.GetFloat(EnginePref);
            engineSlider.value = engineFloat;
        }
    }

    public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat(MusicPref, musicSlider.value);
        PlayerPrefs.SetFloat(FXPref, FXSlider.value);
        PlayerPrefs.SetFloat(EnginePref, engineSlider.value);
    }

    private void OnApplicationFocus(bool inFocus)
    {
        if (!inFocus)
        {
            SaveSoundSettings();
        }

    }

    public void UpdateSound()
    {
        musicAudio.volume = musicSlider.value;

        for (int i =0; i < FXAudio.Length; i++)
        {
            FXAudio[i].volume = FXSlider.value;
        }
        for (int j = 0; j < engineAudio.Length; j++)
        {
            engineAudio[j].volume = engineSlider.value;
        }
    }

}
