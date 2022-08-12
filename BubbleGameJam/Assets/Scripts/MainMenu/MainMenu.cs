using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    private Canvas mainMenu;
    private Canvas optionsMenu;
    private Slider volumeSlider;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {

        mainMenu = GameObject.Find("Main").GetComponent<Canvas>();
        optionsMenu = GameObject.Find("OptionsCanvas").GetComponent<Canvas>();
        audioSource = GetComponent<AudioSource>();

        Button startButton = GameObject.Find("Start").GetComponent<Button>();
        Button optionsButton = GameObject.Find("Options").GetComponent<Button>();
        Button exitButton = GameObject.Find("Exit").GetComponent<Button>();

        startButton.onClick.AddListener(StartGame);
        optionsButton.onClick.AddListener(openOptions);
        exitButton.onClick.AddListener(exitGame);

        OptionButtonInstantiation();

        optionsMenu.gameObject.SetActive(false);
    }
    void StartGame()
    {

    }
    void openOptions()
    {
        mainMenu.gameObject.SetActive(false);
        optionsMenu.gameObject.SetActive(true);
    }
    void exitGame()
    {

    }

    void OptionButtonInstantiation()
    {
        Button backButton = GameObject.Find("Back").GetComponent<Button>();

        volumeSlider = GameObject.Find("Volume").GetComponent<Slider>();

        backButton.onClick.AddListener(returnToMainMenu);
        volumeSlider.onValueChanged.AddListener(delegate { ChangeVolume(); });
        volumeSlider.maxValue = 1;
        volumeSlider.minValue = 0;
    }

    void returnToMainMenu()
    {
        mainMenu.gameObject.SetActive(true);
        optionsMenu.gameObject.SetActive(false);
    }

    void ChangeVolume()
    {
        Debug.Log(volumeSlider.value);
        audioSource.volume = volumeSlider.value;
        Text VolumeText = GetComponent<Text>();
        VolumeText.text = audioSource.volume.ToString();
        Debug.Log(audioSource.volume);

    }
}
