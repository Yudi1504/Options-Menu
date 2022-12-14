using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AudioOptionsManager : MonoBehaviour
{
    public static float masterVolume { get; private set; }
    public static float musicVolume { get; private set; }
    public static float soundEffectsVolume { get; private set; }

    [SerializeField] private TextMeshProUGUI masterSliderText;
    [SerializeField] private TextMeshProUGUI musicSliderText;
    [SerializeField] private TextMeshProUGUI soundEffectsSliderText;

    public void OnMasterSliderValueChange(float value)
    {
        masterVolume = value;

        masterSliderText.text = ((int)(value * 100)).ToString();
        AudioManager.Instance.UpdateMixerVolume();
    }

    public void OnMusicSliderValueChange(float value)
    {
        musicVolume = value;

        musicSliderText.text = ((int)(value * 100)).ToString();
        AudioManager.Instance.UpdateMixerVolume();
    }

    public void OnSoundEffectsSliderValueChange(float value)
    {
        soundEffectsVolume = value;

        soundEffectsSliderText.text = ((int)(value * 100)).ToString();
        AudioManager.Instance.UpdateMixerVolume();
    }
}
