using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

public class OptionsMenu : MonoBehaviour
{
    public GameObject optionsMenu;
    public GameObject exitButton;
    public GameObject audioSubmenu;
    public GameObject graphicsSubmenu;
    public GameObject gameplaySubmenu;
    public TMP_Dropdown resolutionDropdown;
    Resolution[] resolutions;
    public AudioMixer audioMixer;
    int volvol;
    public PersistentData persistentData;
    void Awake()
    {
        GameObject persistentComponents = GameObject.Find("PersistentComponents(Clone)");
        persistentData = persistentComponents.GetComponent<PersistentData>();
        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();
        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);
            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }
    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    public void SetQuality(int qualityIndex){
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
    public void CloseOptionsMenu()
    {
        optionsMenu.SetActive(false);
    }
    public void OpenAudioSubmenu()
    {
        exitButton.SetActive(false);
        audioSubmenu.SetActive(true);
    }
    public void CloseAudioSubmenu()
    {
        exitButton.SetActive(true);
        audioSubmenu.SetActive(false);
    }
    public void OpenGraphicsSubmenu()
    {
        exitButton.SetActive(false);
        graphicsSubmenu.SetActive(true);
    }
    public void CloseGraphicsSubmenu()
    {
        exitButton.SetActive(true);
        graphicsSubmenu.SetActive(false);
    }
    public void OpenGameplaySubmenu()
    {
        exitButton.SetActive(false);
        gameplaySubmenu.SetActive(true);
    }
    public void CloseGameplaySubmenu()
    {
        exitButton.SetActive(true);
        gameplaySubmenu.SetActive(false);
    }
    public void SetVolume(float volume){
        audioMixer.SetFloat("Volume", volume);
        volume = volvol;
    }
    public void SetXSensitivity(float xSens)
    {
        persistentData.xSensitivity = xSens;
    }
    public void SetYSensitivity(float ySens)
    {
        persistentData.ySensitivity = ySens;
    }
}
