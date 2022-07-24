using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    AudioManager audioManager;

    [SerializeField]
    GameObject Player;
    [SerializeField]
    GameObject Level;

    [SerializeField]
    GameObject HUDPaper;
    [SerializeField]
    GameObject HUDTitle;
    [SerializeField]
    GameObject HUDPlayer;
    [SerializeField]
    GameObject HUDStart;

    void Awake()
    {
        Application.targetFrameRate = 60;
        audioManager = this.GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Globals.CurrentGameState == Globals.GameState.TitleScreen)
        {
            UpdateTitle();
        }
        else if (Globals.CurrentGameState == Globals.GameState.Playing)
        {
            UpdatePlaying();
        }
        else if (Globals.CurrentGameState == Globals.GameState.ShowScore)
        {
            UpdateShowScore();
        }
    }

    void UpdateTitle()
    {

    }

    void UpdatePlaying()
    {

    }

    void UpdateShowScore()
    {

    }

    public void StartGame()
    {
        if (Globals.CurrentGameState != Globals.GameState.TitleScreen && Globals.CurrentGameState != Globals.GameState.Restart)
            return;

        audioManager.PlayStartSound();

        HUDPaper.SetActive(false);
        HUDTitle.SetActive(false);
        HUDPlayer.SetActive(false);
        HUDStart.SetActive(false);

        Level.SetActive(true);
        Player.SetActive(true);

        Globals.CurrentGameState = Globals.GameState.Playing;
    }
}
