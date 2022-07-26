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
    GameObject HUDStartButton;
    [SerializeField]
    GameObject HUDOptionsButton;

    [SerializeField]
    GameObject HUDScore;
    [SerializeField]
    GameObject HUDGameOver;
    [SerializeField]
    GameObject HUDPlayAgain;
    [SerializeField]
    TextMeshProUGUI HUDScoreText;
    [SerializeField]
    TextMeshProUGUI HUDBestScoreText;
    [SerializeField]
    GameObject HUDOptions;
    [SerializeField]
    TextMeshProUGUI HUDAudio;
    [SerializeField]
    TextMeshProUGUI HUDMusic;
    [SerializeField]
    TextMeshProUGUI HUDControls;
    bool showOptions = false;

    [SerializeField]
    GameObject HUDDialogBox;
    [SerializeField]
    TextMeshProUGUI HUDDialogBoxText;
    int dialogNum = 0;
    string[] dialog = {"What a beautiful day in Swim City!", "I'll go to the store and get some Seaweed Cereal.", "I hope I don't run into any nasties!"};

    float wipeTimer = 0f;
    float wipeTimerMax = .8f;

    [SerializeField]
    GameObject DiverPrefab;
    [SerializeField]
    GameObject FishPrefab;
    [SerializeField]
    GameObject MolluskPrefab;
    [SerializeField]
    GameObject EnemyContainer;
    int spawnInterval = 0;
    float spawnTimer = 2f;

    void Awake()
    {
        Application.targetFrameRate = 60;
        audioManager = this.GetComponent<AudioManager>();
        Globals.BestScore = Globals.LoadIntFromPlayerPrefs(Globals.BestScorePlayerPrefsKey);

        AudioSource audioSource;
        audioSource = this.GetComponent<AudioSource>();
        int audioOn = Globals.LoadIntFromPlayerPrefs(Globals.AudioPlayerPrefsKey, 1);
        int musicOn = Globals.LoadIntFromPlayerPrefs(Globals.MusicPlayerPrefsKey, 1);
        int controlsOn = Globals.LoadIntFromPlayerPrefs(Globals.ControlsPlayerPrefsKey, 1);
        Globals.AudioOn = audioOn == 1 ? true : false;
        Globals.MusicOn = musicOn == 1 ? true : false;
        Globals.ControlsOn = controlsOn == 1 ? true : false;
        if (Globals.MusicOn)
            audioSource.Play();

        HUDMusic.text = Globals.MusicOn ? "Music: ON" : "Music: OFF";
        HUDAudio.text = Globals.AudioOn ? "Audio: ON" : "Audio: OFF";
        HUDControls.text = Globals.ControlsOn ? "Controls: ON" : "Controls: OFF";
    }

    // Update is called once per frame
    void Update()
    {
        if (Globals.CurrentGameState == Globals.GameState.Starting)
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
                HUDStartButton.SetActive(false);
                HUDOptionsButton.SetActive(false);

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

        if (spawnTimer > 0)
        {
            spawnTimer -= Time.deltaTime;
            if (spawnTimer <= 0)
            {
                if (spawnInterval == 0)
                {
                    // spawn 3 fish
                    GameObject enemyGO1 = (GameObject)Instantiate(FishPrefab, new Vector3(16f, Random.Range(-3f, 3f), 0), Quaternion.identity, EnemyContainer.transform);
                    GameObject enemyGO2 = (GameObject)Instantiate(FishPrefab, new Vector3(19f, Random.Range(-3f, 3f), 0), Quaternion.identity, EnemyContainer.transform);
                    GameObject enemyGO3 = (GameObject)Instantiate(FishPrefab, new Vector3(22f, Random.Range(-3f, 3f), 0), Quaternion.identity, EnemyContainer.transform);
                    spawnTimer = 5f;
                }
                else if (spawnInterval == 1)
                {
                    // spawn 3 mollusk
                    GameObject enemyGO1 = (GameObject)Instantiate(MolluskPrefab, new Vector3(16f, -3.6f, 0), Quaternion.identity, EnemyContainer.transform);
                    GameObject enemyGO2 = (GameObject)Instantiate(MolluskPrefab, new Vector3(19f, -3.6f, 0), Quaternion.identity, EnemyContainer.transform);
                    GameObject enemyGO3 = (GameObject)Instantiate(MolluskPrefab, new Vector3(22f, -3.6f, 0), Quaternion.identity, EnemyContainer.transform);
                    spawnTimer = 7f;
                }
                else if (spawnInterval == 2)
                {
                    // spawn 3 divers
                    GameObject enemyGO1 = (GameObject)Instantiate(DiverPrefab, new Vector3(16f, 8f, 0), Quaternion.identity, EnemyContainer.transform);
                    GameObject enemyGO2 = (GameObject)Instantiate(DiverPrefab, new Vector3(21f, 8f, 0), Quaternion.identity, EnemyContainer.transform);
                    GameObject enemyGO3 = (GameObject)Instantiate(DiverPrefab, new Vector3(26f, 8f, 0), Quaternion.identity, EnemyContainer.transform);
                    spawnTimer = 9f;
                }
                else if (spawnInterval == 3)
                {
                    // fish and mollusk
                    GameObject enemyGO1 = (GameObject)Instantiate(FishPrefab, new Vector3(16f, Random.Range(-1.5f, 3f), 0), Quaternion.identity, EnemyContainer.transform);
                    GameObject enemyGO2 = (GameObject)Instantiate(FishPrefab, new Vector3(19f, Random.Range(-1.5f, 3f), 0), Quaternion.identity, EnemyContainer.transform);
                    GameObject enemyGO3 = (GameObject)Instantiate(FishPrefab, new Vector3(22f, Random.Range(-1.5f, 3f), 0), Quaternion.identity, EnemyContainer.transform);
                    GameObject enemyGO4 = (GameObject)Instantiate(MolluskPrefab, new Vector3(16f, -3.6f, 0), Quaternion.identity, EnemyContainer.transform);
                    GameObject enemyGO5 = (GameObject)Instantiate(MolluskPrefab, new Vector3(19f, -3.6f, 0), Quaternion.identity, EnemyContainer.transform);
                    GameObject enemyGO6 = (GameObject)Instantiate(MolluskPrefab, new Vector3(22f, -3.6f, 0), Quaternion.identity, EnemyContainer.transform);
                    spawnTimer = 5f;
                }
                else if (spawnInterval == 4)
                {
                    // diver and mollusk
                    GameObject enemyGO1 = (GameObject)Instantiate(DiverPrefab, new Vector3(16f, 8f, 0), Quaternion.identity, EnemyContainer.transform);
                    GameObject enemyGO2 = (GameObject)Instantiate(DiverPrefab, new Vector3(21f, 8f, 0), Quaternion.identity, EnemyContainer.transform);
                    GameObject enemyGO3 = (GameObject)Instantiate(DiverPrefab, new Vector3(26f, 8f, 0), Quaternion.identity, EnemyContainer.transform);
                    GameObject enemyGO4 = (GameObject)Instantiate(MolluskPrefab, new Vector3(16f, -3.6f, 0), Quaternion.identity, EnemyContainer.transform);
                    GameObject enemyGO5 = (GameObject)Instantiate(MolluskPrefab, new Vector3(19f, -3.6f, 0), Quaternion.identity, EnemyContainer.transform);
                    GameObject enemyGO6 = (GameObject)Instantiate(MolluskPrefab, new Vector3(22f, -3.6f, 0), Quaternion.identity, EnemyContainer.transform);
                    spawnTimer = 7f;
                }
                else if (spawnInterval >= 5)
                {
                    float randomVal = Random.Range(0f, 100.0f);
                    if (randomVal < 25f)
                    {
                        // school of fish
                        GameObject enemyGO1 = (GameObject)Instantiate(FishPrefab, new Vector3(16f, Random.Range(-3f, 3f), 0), Quaternion.identity, EnemyContainer.transform);
                        GameObject enemyGO2 = (GameObject)Instantiate(FishPrefab, new Vector3(19f, Random.Range(-3f, 3f), 0), Quaternion.identity, EnemyContainer.transform);
                        GameObject enemyGO3 = (GameObject)Instantiate(FishPrefab, new Vector3(22f, Random.Range(-3f, 3f), 0), Quaternion.identity, EnemyContainer.transform);
                        GameObject enemyGO4 = (GameObject)Instantiate(FishPrefab, new Vector3(25f, Random.Range(-3f, 3f), 0), Quaternion.identity, EnemyContainer.transform);
                        GameObject enemyGO5 = (GameObject)Instantiate(FishPrefab, new Vector3(28f, Random.Range(-3f, 3f), 0), Quaternion.identity, EnemyContainer.transform);
                    }
                    else if (randomVal < 50f)
                    {
                        // school of fish and mollusk
                        GameObject enemyGO1 = (GameObject)Instantiate(FishPrefab, new Vector3(16f, Random.Range(-1.5f, 3f), 0), Quaternion.identity, EnemyContainer.transform);
                        GameObject enemyGO2 = (GameObject)Instantiate(FishPrefab, new Vector3(19f, Random.Range(-1.5f, 3f), 0), Quaternion.identity, EnemyContainer.transform);
                        GameObject enemyGO3 = (GameObject)Instantiate(FishPrefab, new Vector3(22f, Random.Range(-1.5f, 3f), 0), Quaternion.identity, EnemyContainer.transform);
                        GameObject enemyGO4 = (GameObject)Instantiate(MolluskPrefab, new Vector3(16f, -3.6f, 0), Quaternion.identity, EnemyContainer.transform);
                        GameObject enemyGO5 = (GameObject)Instantiate(MolluskPrefab, new Vector3(19f, -3.6f, 0), Quaternion.identity, EnemyContainer.transform);
                        GameObject enemyGO6 = (GameObject)Instantiate(MolluskPrefab, new Vector3(22f, -3.6f, 0), Quaternion.identity, EnemyContainer.transform);
                    }
                    else if (randomVal < 75f)
                    {
                        // diver and mollusk
                        GameObject enemyGO1 = (GameObject)Instantiate(DiverPrefab, new Vector3(16f, 8f, 0), Quaternion.identity, EnemyContainer.transform);
                        GameObject enemyGO2 = (GameObject)Instantiate(DiverPrefab, new Vector3(21f, 8f, 0), Quaternion.identity, EnemyContainer.transform);
                        GameObject enemyGO3 = (GameObject)Instantiate(DiverPrefab, new Vector3(26f, 8f, 0), Quaternion.identity, EnemyContainer.transform);
                        GameObject enemyGO4 = (GameObject)Instantiate(MolluskPrefab, new Vector3(16f, -3.6f, 0), Quaternion.identity, EnemyContainer.transform);
                        GameObject enemyGO5 = (GameObject)Instantiate(MolluskPrefab, new Vector3(19f, -3.6f, 0), Quaternion.identity, EnemyContainer.transform);
                        GameObject enemyGO6 = (GameObject)Instantiate(MolluskPrefab, new Vector3(22f, -3.6f, 0), Quaternion.identity, EnemyContainer.transform);
                    }
                    else
                    {
                        // all 3
                        GameObject enemyGO1 = (GameObject)Instantiate(DiverPrefab, new Vector3(16f, 8f, 0), Quaternion.identity, EnemyContainer.transform);
                        GameObject enemyGO2 = (GameObject)Instantiate(DiverPrefab, new Vector3(21f, 8f, 0), Quaternion.identity, EnemyContainer.transform);
                        GameObject enemyGO3 = (GameObject)Instantiate(DiverPrefab, new Vector3(26f, 8f, 0), Quaternion.identity, EnemyContainer.transform);
                        GameObject enemyGO4 = (GameObject)Instantiate(MolluskPrefab, new Vector3(16f, -3.6f, 0), Quaternion.identity, EnemyContainer.transform);
                        GameObject enemyGO5 = (GameObject)Instantiate(MolluskPrefab, new Vector3(19f, -3.6f, 0), Quaternion.identity, EnemyContainer.transform);
                        GameObject enemyGO6 = (GameObject)Instantiate(MolluskPrefab, new Vector3(22f, -3.6f, 0), Quaternion.identity, EnemyContainer.transform);
                        GameObject enemyGO7 = (GameObject)Instantiate(FishPrefab, new Vector3(16f, Random.Range(-1.5f, 3f), 0), Quaternion.identity, EnemyContainer.transform);
                        GameObject enemyGO8 = (GameObject)Instantiate(FishPrefab, new Vector3(19f, Random.Range(-1.5f, 3f), 0), Quaternion.identity, EnemyContainer.transform);
                        GameObject enemyGO9 = (GameObject)Instantiate(FishPrefab, new Vector3(22f, Random.Range(-1.5f, 3f), 0), Quaternion.identity, EnemyContainer.transform);
                    }
                    float newSpeed = Mathf.Min(Globals.maxSpeed, Globals.ScrollSpeed.x + 1f);
                    Globals.ScrollSpeed = new Vector2(newSpeed, Globals.ScrollSpeed.y);
                    spawnTimer = 5f;
                }
                spawnInterval++;
            }
        }
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
        HUDScoreText.text = "Score: " + Globals.CurrentScore;
        HUDBestScoreText.text = "Top Score: " + Globals.BestScore;
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
        spawnTimer = 4f;
        spawnInterval = 0;
        HUDScore.GetComponent<TextMeshProUGUI>().text = Globals.CurrentScore.ToString();
    }

    public void ToggleOptions()
    {
        showOptions = !showOptions;
        audioManager.PlayMenuSound();
        if (showOptions)
            HUDOptions.GetComponent<MoveNormal>().MoveUp();
        else
            HUDOptions.GetComponent<MoveNormal>().MoveDown();
    }

    public void ToggleMusic()
    {
        Globals.MusicOn = !Globals.MusicOn;
        audioManager.PlayMenuSound();
        if (Globals.MusicOn)
            audioManager.StartMusic();
        else
            audioManager.StopMusic();
        HUDMusic.text = Globals.MusicOn ? "Music: ON" : "Music: OFF";
        Globals.SaveIntToPlayerPrefs(Globals.MusicPlayerPrefsKey, Globals.MusicOn ? 1 : 0);
    }

    public void ToggleAudio()
    {
        Globals.AudioOn = !Globals.AudioOn;
        audioManager.PlayMenuSound();
        HUDAudio.text = Globals.AudioOn ? "Audio: ON" : "Audio: OFF";
        Globals.SaveIntToPlayerPrefs(Globals.AudioPlayerPrefsKey, Globals.AudioOn ? 1 : 0);
    }

    public void ToggleControls()
    {
        Globals.ControlsOn = !Globals.ControlsOn;
        audioManager.PlayMenuSound();
        HUDControls.text = Globals.ControlsOn ? "Controls: ON" : "Controls: OFF";
        Globals.SaveIntToPlayerPrefs(Globals.ControlsPlayerPrefsKey, Globals.ControlsOn ? 1 : 0);
    }
}
