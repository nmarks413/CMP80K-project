using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Volume : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource audioSource;
    Slider VolumeSlider;
    void Start()
    {
        Slider VolumeSlider = GetComponent<Slider>();
        VolumeSlider.onValueChanged.AddListener(delegate { changeVolume(); });
        //VolumeSlider.minValue = 0.0001f;
        //VolumeSlider.maxValue = 1;
        audioSource = GetComponent<AudioSource>();
    }

    void changeVolume()
    {
        Debug.Log(VolumeSlider.value);
        audioSource.volume = VolumeSlider.value;
        Text VolumeText = GetComponent<Text>();
        VolumeText.text = audioSource.volume.ToString();
        Debug.Log(audioSource.volume);
    }
}
