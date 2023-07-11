using UnityEngine;

public class AudioSettings : MonoBehaviour
{
    private static readonly string MusicPref = "MusicPref";
    private static readonly string FXPref = "FXPref";
    private static readonly string EnginePref = "EnginePref";
    private float musicFloat, FXFloat, engineFloat;
    public AudioSource musicAudio;
    public AudioSource[] engineAudio;
    public AudioSource[] FXAudio;
    void Awake()
    {
        ContinueSettings();
    }

   private void ContinueSettings()
    {
        musicFloat = PlayerPrefs.GetFloat(MusicPref);
        FXFloat = PlayerPrefs.GetFloat(FXPref);
        engineFloat = PlayerPrefs.GetFloat(EnginePref);

        musicAudio.volume = musicFloat;

        for (int i = 0; i < FXAudio.Length; i++)
        {
            FXAudio[i].volume = FXFloat;
        }
        for (int j = 0; j < engineAudio.Length; j++)
        {
            engineAudio[j].volume = engineFloat;
        }
    }
}
