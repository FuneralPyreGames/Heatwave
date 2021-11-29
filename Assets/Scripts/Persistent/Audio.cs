using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] AudioClip pilesOfSnow;
    [SerializeField] AudioClip vehicularCombat;
    [SerializeField] AudioClip Stardust;
    [SerializeField] AudioClip downWithTheShip;
    [SerializeField] AudioClip theTeenageGeneration;
    [SerializeField] AudioClip cursedGameOver;
    [SerializeField] AudioClip openingCutsceneAudio;
    public AudioSource audioSource;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void PlayRandomSong()
    {
        int songSelection = Random.Range(1, 5);
        switch (songSelection)
        {
            case 1:
                audioSource.clip = pilesOfSnow;
                audioSource.Play();
                break;
            case 2:
                audioSource.clip = vehicularCombat;
                audioSource.Play();
                break;
            case 3:
                audioSource.clip = Stardust;
                audioSource.Play();
                break;
            case 4:
                audioSource.clip = downWithTheShip;
                audioSource.Play();
                break;
            case 5:
                audioSource.clip = theTeenageGeneration;
                audioSource.Play();
                break;
        }
    }
    public void PlayGameOverMusic()
    {
        audioSource.clip = cursedGameOver;
        audioSource.Play();
    }
    public void PlayOpeningCutsceneAudio()
    {
        audioSource.clip = openingCutsceneAudio;
        audioSource.Play();
    }
}
