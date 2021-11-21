using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public GameObject optionsMenu;
    public GameObject exitButton;
    public GameObject audioSubmenu;
    public GameObject graphicsSubmenu;
    public GameObject gameplaySubmenu;
    public void SetQuality(int qualityIndex){
        QualitySettings.SetQualityLevel(qualityIndex);
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
}
