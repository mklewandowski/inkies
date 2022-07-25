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
    GameObject[] Blocks;

    [SerializeField]
    GameObject HUDWipeLeft;
    [SerializeField]
    GameObject HUDWipeRight;
    [SerializeField]
    GameObject HUDWipeTop;
    [SerializeField]
    GameObject HUDWipeBottom;

    [SerializeField]
    GameObject HUDPaper;
    [SerializeField]
    GameObject HUDTitle;
    [SerializeField]
    GameObject HUDPlayer;
    [SerializeField]
    GameObject HUDStart;

    [SerializeField]
    GameObject HUDScore;
    [SerializeField]
    GameObject HUDGameOver;
    [SerializeField]
    GameObject HUDPlayAgain;

    [SerializeField]
    GameObject HUDDialogBox;
    [SerializeField]
    TextMeshProUGUI HUDDialogBoxText;
    int dialogNum = 0;
    string[] dialog = {"What a beautiful day in Swim City!", "I'll go to the store and get some Seaweed Cereal.", "I hope I don't run into any nasties!"};

    float wipeTimer = 0f;
    float wipeTimerMax = .8f;

    void Awake()
    {
        Application.targetFrameRate = 60;
        audioManager = this.GetComponent<AudioManager>();
        Globals.BestScore = Globals.LoadIntFromPlayerPrefs(Globals.BestScorePlayerPrefsKey);
    }

    // Update is called once per frame
    void Update()
    {
        if (Globals.CurrentGameState == Globals.GameState.TitleScreen)
        {
            UpdateTitle();
        }
        else if (Globals.CurrentGameState == Globals.GameState.Starting)
        {
            UpdateStarting();
        }
        else if (Globals.CurrentGameState == Globals.GameState.IntroDialog)
        {
            UpdateIntroDialog();
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

    void UpdateStarting()
    {
        if (wipeTimer > 0)
        {
            wipeTimer -= Time.deltaTime;
            if (wipeTimer <= 0)
            {
                HUDPaper.SetActive(false);
                HUDTitle.SetActive(false);
                HUDPlayer.SetActive(false);
                HUDStart.SetActive(false);

                Level.SetActive(true);

                Globals.CurrentScore = 0;
                HUDScore.GetComponent<TextMeshProUGUI>().text = Globals.CurrentScore.ToString();
                HUDScore.SetActive(true);

                HUDWipeLeft.GetComponent<MoveNormal>().MoveLeft();
                HUDWipeRight.GetComponent<MoveNormal>().MoveRight();
                HUDWipeTop.GetComponent<MoveNormal>().MoveUp();
                HUDWipeBottom.GetComponent<MoveNormal>().MoveDown();

                wipeTimer = wipeTimerMax;
                Globals.CurrentGameState = Globals.GameState.IntroDialog;
            }
        }
    }

    void UpdateIntroDialog()
    {
        if (wipeTimer > 0)
        {
            wipeTimer -= Time.deltaTime;
            if (wipeTimer <= 0)
            {
                HUDDialogBox.GetComponent<MoveNormal>().MoveDown();
            }
        }
    }

    void UpdatePlaying()
    {
        float blockMinX = -12f;
        for (int i = 0; i < Blocks.Length; i++)
        {
            if (Blocks[i].transform.localPosition.x < blockMinX)
            {
                int abutIndex = i == 0 ? Blocks.Length - 1 : i - 1;
                Blocks[i].transform.localPosition = new Vector3(
                        Blocks[abutIndex].transform.localPosition.x + 1.7f,
                        Blocks[i].transform.localPosition.y,
                        Blocks[i].transform.localPosition.z
                    );
            }
        }
    }

    void UpdateShowScore()
    {

    }

    void FixedUpdate()
    {
        if (Globals.CurrentGameState == Globals.GameState.Playing || Globals.CurrentGameState == Globals.GameState.ShowScore)
        {
            Vector2 blockMovement = new Vector2 (Globals.ScrollSpeed.x * Globals.ScrollDirection.x, 0);
            for (int i = 0; i < Blocks.Length; i++)
            {
                Blocks[i].GetComponent<Rigidbody2D>().velocity = blockMovement;
            }
        }
    }

    public void StartGameIntro()
    {
        if (Globals.CurrentGameState != Globals.GameState.TitleScreen && Globals.CurrentGameState != Globals.GameState.Restart)
            return;

        audioManager.PlayStartSound();

        HUDWipeLeft.GetComponent<MoveNormal>().MoveRight();
        HUDWipeRight.GetComponent<MoveNormal>().MoveLeft();
        HUDWipeTop.GetComponent<MoveNormal>().MoveDown();
        HUDWipeBottom.GetComponent<MoveNormal>().MoveUp();

        wipeTimer = wipeTimerMax;
        Globals.CurrentGameState = Globals.GameState.Starting;
    }

    public void IncrementScore(int points)
    {
        Globals.CurrentScore = Globals.CurrentScore + points;
        HUDScore.GetComponent<TextMeshProUGUI>().text = Globals.CurrentScore.ToString();
    }

    public void AdvanceDialog()
    {
        audioManager.PlayMenuSound();

        dialogNum++;
        if (dialogNum >= dialog.Length)
        {
            HUDDialogBox.GetComponent<MoveNormal>().MoveUp();
            StartGame();
        }
        else
        {
            HUDDialogBoxText.text = dialog[dialogNum];
        }
    }

    public void StartGame()
    {
        Player.SetActive(true);
        Globals.CurrentGameState = Globals.GameState.Playing;
        Globals.ScrollSpeed = new Vector3(Globals.minSpeed, 0, 0);
    }

    public void GameOver()
    {
        if (Globals.CurrentScore > Globals.BestScore)
        {
            Globals.BestScore = Globals.CurrentScore;
            Globals.SaveIntToPlayerPrefs(Globals.BestScorePlayerPrefsKey, Globals.BestScore);
        }
        Globals.ScrollSpeed = new Vector3(0, 0, 0);
        Globals.CurrentGameState = Globals.GameState.ShowScore;
        HUDGameOver.GetComponent<MoveNormal>().MoveDown();
        HUDPlayAgain.GetComponent<MoveNormal>().MoveUp();
    }

    public void RestartGame()
    {
        audioManager.PlayStartSound();
        Player.GetComponent<Player>().Reset();
        Globals.CurrentGameState = Globals.GameState.Playing;
        Globals.ScrollSpeed = new Vector3(Globals.minSpeed, 0, 0);
        HUDGameOver.GetComponent<MoveNormal>().MoveUp();
        HUDPlayAgain.GetComponent<MoveNormal>().MoveDown();
        Globals.CurrentScore = 0;
        HUDScore.GetComponent<TextMeshProUGUI>().text = Globals.CurrentScore.ToString();
    }
}
