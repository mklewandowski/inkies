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
    GameObject Controls;
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
    GameObject HUDAboutButton;

    [SerializeField]
    GameObject HUDScore;
    [SerializeField]
    TextMeshProUGUI HUDCoinsText;
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
    [SerializeField]
    TextMeshProUGUI HUDEasyMode;
    [SerializeField]
    GameObject HUDAboutText;
    bool showOptions = false;
    bool showAbout = false;

    [SerializeField]
    GameObject HUDCharacterSelect;
    [SerializeField]
    GameObject HUDDialogBox;
    [SerializeField]
    TextMeshProUGUI HUDDialogBoxText;
    int dialogNum = 0;
    string[] dialog1 = {"What a beautiful day in Swim City!", "I have to meet my friends at Seaweed Burger.", "I hope I don't run into any nasties!"};
    string[] dialog2 = {"It's still a long swim to Seaweed Burger.", "I can't wait to get a Saltwater Shake!"};
    string[] dialog3 = {"My tentacles are tired from all this action!", "I should have just taken a Tuna Taxi."};
    string[] dialog4 = {"Just a little farther and I'll be at Seaweed Burger.", "All my friends are waiting for me. I better hurry!"};
    [SerializeField]
    Sprite[] HUDPlayerSprites;
    [SerializeField]
    GameObject HUDDialogPlayer;
    [SerializeField]
    GameObject HUDLevelComplete;
    [SerializeField]
    GameObject HUDNextLevel;

    float levelCompleteTimer = 0f;
    float levelCompleteTimerMax = 3f;

    float wipeTimer = 0f;
    float wipeTimerMax = .8f;

    [SerializeField]
    GameObject DiverPrefab;
    [SerializeField]
    GameObject FishPrefab;
    [SerializeField]
    GameObject MolluskPrefab;
    [SerializeField]
    GameObject GunMolluskPrefab;
    [SerializeField]
    GameObject GunFishPrefab;
    [SerializeField]
    GameObject WaveEndPrefab;
    [SerializeField]
    GameObject LevelEndPrefab;
    [SerializeField]
    GameObject EnemyContainer;
    int spawnInterval = 0;
    int wavesPerLevel = 10;
    int wavesThisLevel = 0;
    List<EnemyWave> waves = new List<EnemyWave>();

    [SerializeField]
    GameObject CoinContainer;
    [SerializeField]
    GameObject CoinPrefab;
    float coinSpawnDistance = 3f;
    float distanceUntilCoinSpawn = 3f;

    [SerializeField]
    GameObject PowerUpPrefab;

    [SerializeField]
    GameObject[] HUDUnlockBanners;
    [SerializeField]
    GameObject[] HUDCharacterSelectImages;

    [SerializeField]
    GameObject HUDPowerupInk;
    [SerializeField]
    GameObject HUDPowerupInvincible;
    [SerializeField]
    GameObject HUDPowerupDisguise;

    void Awake()
    {
        Application.targetFrameRate = 60;
        audioManager = this.GetComponent<AudioManager>();

        Globals.LoadCharacterUnlockStatesFromPlayerPrefs();
        for (int x = 0; x < HUDUnlockBanners.Length; x++)
        {
            if (Globals.CharacterUnlockStates[x] == 1)
            {
                HUDUnlockBanners[x].SetActive(false);
                HUDCharacterSelectImages[x].GetComponent<Image>().color = new Color(1f, 1f, 1f);
            }
        }

        Globals.BestScore = Globals.LoadIntFromPlayerPrefs(Globals.BestScorePlayerPrefsKey);

        Globals.Coins = Globals.LoadIntFromPlayerPrefs(Globals.CoinsPlayerPrefsKey);
        UpdateCoins();

        AudioSource audioSource;
        audioSource = this.GetComponent<AudioSource>();
        int audioOn = Globals.LoadIntFromPlayerPrefs(Globals.AudioPlayerPrefsKey, 1);
        int musicOn = Globals.LoadIntFromPlayerPrefs(Globals.MusicPlayerPrefsKey, 1);
        int controlsOn = Globals.LoadIntFromPlayerPrefs(Globals.ControlsPlayerPrefsKey, 0);
        int easyMode = Globals.LoadIntFromPlayerPrefs(Globals.EasyModePlayerPrefsKey, 1);
        Globals.AudioOn = audioOn == 1 ? true : false;
        Globals.MusicOn = musicOn == 1 ? true : false;
        Globals.ControlsOn = controlsOn == 1 ? true : false;
        Globals.EasyMode = easyMode == 1 ? true : false;
        if (Globals.MusicOn)
            audioSource.Play();

        HUDMusic.text = Globals.MusicOn ? "Music: ON" : "Music: OFF";
        HUDAudio.text = Globals.AudioOn ? "Audio: ON" : "Audio: OFF";
        HUDControls.text = Globals.ControlsOn ? "D-pad: ON" : "D-pad: OFF";
        HUDEasyMode.text = Globals.EasyMode ? "Mode: EASY" : "Mode: NORMAL";

        LevelBuilder.BuildLevels(waves);
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
        else if (Globals.CurrentGameState == Globals.GameState.LevelComplete)
        {
            UpdateLevelComplete();
        }
        else if (Globals.CurrentGameState == Globals.GameState.NextLevel)
        {
            UpdateNextLevel();
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
                HUDAboutButton.SetActive(false);

                Level.SetActive(true);

                dialogNum = 0;

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

    void UpdateTitle()
    {
        if (wipeTimer > 0)
        {
            wipeTimer -= Time.deltaTime;
            if (wipeTimer <= 0)
            {
                HUDPaper.SetActive(true);
                HUDTitle.SetActive(true);
                HUDPlayer.SetActive(true);
                HUDStartButton.SetActive(true);
                HUDOptionsButton.SetActive(true);
                HUDAboutButton.SetActive(true);

                Level.SetActive(false);
                HUDScore.SetActive(false);
                Player.SetActive(false);
                Controls.SetActive(false);

                HUDWipeLeft.GetComponent<MoveNormal>().MoveLeft();
                HUDWipeRight.GetComponent<MoveNormal>().MoveRight();
                HUDWipeTop.GetComponent<MoveNormal>().MoveUp();
                HUDWipeBottom.GetComponent<MoveNormal>().MoveDown();
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
                HUDCharacterSelect.GetComponent<MoveNormal>().MoveDown();
            }
        }
    }

    void UpdatePlaying()
    {
        MoveBlocks();
        SpawnCoins();
    }

    void MoveBlocks()
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

    private void UpdateLevelComplete()
    {
        levelCompleteTimer -= Time.deltaTime;
        if (levelCompleteTimer <= 0)
        {
            if (Globals.CurrentLevel == Globals.MaxLevelNum)
            {
                // WTD WTD WTD end game
            }
            else
                HUDNextLevel.GetComponent<MoveNormal>().MoveUp();

            Globals.CurrentGameState = Globals.GameState.NextLevel;
        }
        MoveBlocks();
    }

    private void UpdateNextLevel()
    {
        MoveBlocks();
        if (wipeTimer > 0)
        {
            wipeTimer -= Time.deltaTime;
            if (wipeTimer <= 0)
            {
                Globals.CurrentLevel++;
                wavesThisLevel = 0;
                distanceUntilCoinSpawn = coinSpawnDistance;

                HUDWipeLeft.GetComponent<MoveNormal>().MoveLeft();
                HUDWipeRight.GetComponent<MoveNormal>().MoveRight();
                HUDWipeTop.GetComponent<MoveNormal>().MoveUp();
                HUDWipeBottom.GetComponent<MoveNormal>().MoveDown();

                Player.SetActive(false);

                dialogNum = 0;
                string currDialog = dialog1[dialogNum];
                if (Globals.CurrentLevel == 1)
                    currDialog = dialog2[dialogNum];
                else if (Globals.CurrentLevel == 2)
                    currDialog = dialog3[dialogNum];
                else if (Globals.CurrentLevel == 3)
                    currDialog = dialog4[dialogNum];
                HUDDialogBoxText.text = Globals.GetPlayerName() + ": " + currDialog;
                HUDDialogBox.GetComponent<MoveNormal>().MoveDown();
            }
        }
    }

    public void SpawnWave()
    {
        if (Globals.CurrentGameState != Globals.GameState.Playing)
            return;

        if (spawnInterval >= waves.Count)
        {
            spawnInterval = 0;
            float newSpeed = Mathf.Min(Globals.maxSpeed, Globals.ScrollSpeed.x + 2f);
            Globals.ScrollSpeed = new Vector2(newSpeed, Globals.ScrollSpeed.y);
        }
        int numInCol = 5;
        float[] yPositions = {8f, 3f, .75f, -1.5f, -3.6f};
        float xPositionDelta = 3f;
        float xPosition = 14f;
        float extraXmovement = 2f;
        for (int x = 0; x < waves[spawnInterval].Enemies.Length; x++)
        {
            if (x > 0 && (x % numInCol) == 0)
                xPosition = xPosition + xPositionDelta;
            Enemy.EnemyType type = waves[spawnInterval].Enemies[x];
            if (type != Enemy.EnemyType.None)
            {
                GameObject enemyPrefab = FishPrefab;
                if (type == Enemy.EnemyType.Diver)
                    enemyPrefab = DiverPrefab;
                else if (type == Enemy.EnemyType.Mollusk)
                    enemyPrefab = MolluskPrefab;
                else if (type == Enemy.EnemyType.GunMollusk)
                    enemyPrefab = GunMolluskPrefab;
                else if (type == Enemy.EnemyType.GunFish)
                    enemyPrefab = GunFishPrefab;
                else if (type == Enemy.EnemyType.GunFishBounce)
                    enemyPrefab = GunFishPrefab;
                else if (type == Enemy.EnemyType.GunFishHard)
                    enemyPrefab = GunFishPrefab;
                GameObject enemyGO = (GameObject)Instantiate(enemyPrefab, new Vector3(xPosition, yPositions[x % numInCol], 0), enemyPrefab.transform.rotation, EnemyContainer.transform);
                if (type == Enemy.EnemyType.Diver || type == Enemy.EnemyType.Mollusk ||  type == Enemy.EnemyType.GunMollusk)
                    extraXmovement = 1f;
            }
        }
        // make the wave or level end
        if (wavesThisLevel == (wavesPerLevel - 1))
        {
            GameObject levelEnd = (GameObject)Instantiate(LevelEndPrefab, new Vector3(xPosition + 1f, 0, 0), Quaternion.identity, EnemyContainer.transform);
            levelEnd.GetComponent<Enemy>().SetExtraXMovement(extraXmovement);
        }
        else
        {
            GameObject waveEnd = (GameObject)Instantiate(WaveEndPrefab, new Vector3(xPosition + 1f, 0, 0), Quaternion.identity, EnemyContainer.transform);
            waveEnd.GetComponent<Enemy>().SetExtraXMovement(extraXmovement);
        }

        // powerup
        if (spawnInterval > 0 && (spawnInterval - 1) % 3 == 0)
        {
            GameObject powerupGO = (GameObject)Instantiate(PowerUpPrefab, new Vector3(xPosition + 2f, Random.Range(-1f, 4.5f), 0), Quaternion.identity, CoinContainer.transform);
            int maxPowerupRange = 2;
            if (spawnInterval >= 15)
                maxPowerupRange = 3;
            powerupGO.GetComponent<PowerUp>().SetType((PowerUp.PowerupType)Random.Range(0, maxPowerupRange));
        }

        spawnInterval++;
        wavesThisLevel++;
    }

    void SpawnCoins()
    {
        if (wavesThisLevel == wavesPerLevel)
            return;
        distanceUntilCoinSpawn = distanceUntilCoinSpawn - Globals.ScrollSpeed.x * Time.deltaTime;
        if (distanceUntilCoinSpawn <= 0)
        {
            float[] coinYPositions = {4f, 2f, 0f, -2f};
            float xPosition = 12f;
            for (int y = 0; y < coinYPositions.Length; y++)
            {
                float rand = Random.Range(0f, 100f);
                if (rand < 10f)
                {
                    GameObject coinGO = (GameObject)Instantiate(CoinPrefab, new Vector3(xPosition, coinYPositions[y], 0), Quaternion.identity, CoinContainer.transform);
                }
            }
            distanceUntilCoinSpawn = coinSpawnDistance;
        }
    }

    void FixedUpdate()
    {
        if (Globals.CurrentGameState == Globals.GameState.Playing || Globals.CurrentGameState == Globals.GameState.ShowScore
            || Globals.CurrentGameState == Globals.GameState.LevelComplete || Globals.CurrentGameState == Globals.GameState.NextLevel)
        {
            Vector2 blockMovement = new Vector2 (Globals.ScrollSpeed.x * Globals.ScrollDirection.x, 0);
            for (int i = 0; i < Blocks.Length; i++)
            {
                Blocks[i].GetComponent<Rigidbody2D>().velocity = blockMovement;
            }
        }
    }

    public void GetCoin()
    {
        Globals.Coins++;
        HUDCoinsText.text = Globals.Coins.ToString();
    }

    public void GetPowerUp(PowerUp.PowerupType powerupType)
    {
        if (powerupType == PowerUp.PowerupType.Invincible)
        {
            HUDPowerupInvincible.GetComponent<HUDPowerUp>().Show();
            HUDPowerupInk.GetComponent<HUDPowerUp>().Hide();
            HUDPowerupDisguise.GetComponent<HUDPowerUp>().Hide();
        }
        else if (powerupType == PowerUp.PowerupType.SuperInk)
        {
            HUDPowerupInk.GetComponent<HUDPowerUp>().Show();
            HUDPowerupInvincible.GetComponent<HUDPowerUp>().Hide();
            HUDPowerupDisguise.GetComponent<HUDPowerUp>().Hide();
        }
        else if (powerupType == PowerUp.PowerupType.Disguise)
        {
            HUDPowerupDisguise.GetComponent<HUDPowerUp>().Show();
            HUDPowerupInk.GetComponent<HUDPowerUp>().Hide();
            HUDPowerupInvincible.GetComponent<HUDPowerUp>().Hide();
        }
    }

    public void UpdateCoins()
    {
        HUDCoinsText.text = Globals.Coins.ToString();
    }

    public void RemoveOldLevelContent()
    {
        Enemy[] enemies = GameObject.FindObjectsOfType<Enemy>(true);
        for (int i = 0; i < enemies.Length; i++)
        {
            Destroy(enemies[i].gameObject);
        }
        Coin[] coins = GameObject.FindObjectsOfType<Coin>(true);
        for (int i = 0; i < coins.Length; i++)
        {
            Destroy(coins[i].gameObject);
        }
        PowerUp[] pups = GameObject.FindObjectsOfType<PowerUp>(true);
        for (int i = 0; i < pups.Length; i++)
        {
            Destroy(pups[i].gameObject);
        }
    }

    public void StartGameIntro()
    {
        if (Globals.CurrentGameState != Globals.GameState.TitleScreen && Globals.CurrentGameState != Globals.GameState.Restart)
            return;

        audioManager.PlayStartSound();

        Player.GetComponent<Player>().Reset();
        RemoveOldLevelContent();

        HUDWipeLeft.GetComponent<MoveNormal>().MoveRight();
        HUDWipeRight.GetComponent<MoveNormal>().MoveLeft();
        HUDWipeTop.GetComponent<MoveNormal>().MoveDown();
        HUDWipeBottom.GetComponent<MoveNormal>().MoveUp();
        HUDOptions.GetComponent<MoveNormal>().MoveDown();
        HUDAboutText.GetComponent<MoveNormal>().MoveDown();

        wipeTimer = wipeTimerMax;
        Globals.CurrentGameState = Globals.GameState.Starting;
    }

    public void ReturnHome()
    {
        audioManager.PlayMenuSound();

        HUDWipeLeft.GetComponent<MoveNormal>().MoveRight();
        HUDWipeRight.GetComponent<MoveNormal>().MoveLeft();
        HUDWipeTop.GetComponent<MoveNormal>().MoveDown();
        HUDWipeBottom.GetComponent<MoveNormal>().MoveUp();
        HUDGameOver.GetComponent<MoveNormal>().MoveUp();
        HUDPlayAgain.GetComponent<MoveNormal>().MoveDown();
        wipeTimer = wipeTimerMax;
        Globals.CurrentGameState = Globals.GameState.TitleScreen;
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
        int dialogLength = dialog1.Length;
        if (Globals.CurrentLevel == 1)
            dialogLength = dialog2.Length;
        else if (Globals.CurrentLevel == 2)
            dialogLength = dialog3.Length;
        else if (Globals.CurrentLevel == 3)
            dialogLength = dialog4.Length;
        if (dialogNum >= dialogLength)
        {
            HUDDialogBox.GetComponent<MoveNormal>().MoveUp();
            StartGame();
        }
        else
        {
            string currDialog = dialog1[dialogNum];
            if (Globals.CurrentLevel == 1)
                currDialog = dialog2[dialogNum];
            else if (Globals.CurrentLevel == 2)
                currDialog = dialog3[dialogNum];
            else if (Globals.CurrentLevel == 3)
                currDialog = dialog4[dialogNum];
            HUDDialogBoxText.text = Globals.GetPlayerName() + ": " + currDialog;
        }
    }

    public void StartGame()
    {
        Player.GetComponent<Player>().Reset();
        RemoveOldLevelContent();
        Player.SetActive(true);
        Controls.SetActive(Globals.ControlsOn);
        Globals.CurrentGameState = Globals.GameState.Playing;
        Globals.ScrollSpeed = new Vector3(Globals.EasyMode ? Globals.minSpeed : Globals.minSpeed + 2f, 0, 0);
        if (Globals.CurrentLevel == 0)
        {
            spawnInterval = 0;
            wavesThisLevel = 0;
        }
        SpawnWave();
    }

    public void GameOver()
    {
        Globals.SaveIntToPlayerPrefs(Globals.CoinsPlayerPrefsKey, Globals.Coins);
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
        RemoveOldLevelContent();
        Globals.CurrentGameState = Globals.GameState.Playing;
        Globals.ScrollSpeed = new Vector3(Globals.EasyMode ? Globals.minSpeed : Globals.minSpeed + 2f, 0, 0);
        HUDGameOver.GetComponent<MoveNormal>().MoveUp();
        HUDPlayAgain.GetComponent<MoveNormal>().MoveDown();
        Globals.CurrentScore = 0;
        Globals.CurrentLevel = 0;
        Globals.CurrentLives = 3;
        spawnInterval = 0;
        wavesThisLevel = 0;
        distanceUntilCoinSpawn = coinSpawnDistance;
        SpawnWave();
        HUDScore.GetComponent<TextMeshProUGUI>().text = Globals.CurrentScore.ToString();
    }

    public void LevelComplete()
    {
        audioManager.PlayLevelCompleteSound();
        HUDLevelComplete.GetComponent<MoveNormal>().MoveDown();
        levelCompleteTimer = levelCompleteTimerMax;
        RemoveOldLevelContent();
        Globals.CurrentGameState = Globals.GameState.LevelComplete;

        // WTD WTD WTD remove powerups
    }

    public void StartNextLevel()
    {
        audioManager.PlayStartSound();
        HUDLevelComplete.GetComponent<MoveNormal>().MoveUp();
        HUDNextLevel.GetComponent<MoveNormal>().MoveDown();
        HUDWipeLeft.GetComponent<MoveNormal>().MoveRight();
        HUDWipeRight.GetComponent<MoveNormal>().MoveLeft();
        HUDWipeTop.GetComponent<MoveNormal>().MoveDown();
        HUDWipeBottom.GetComponent<MoveNormal>().MoveUp();
        wipeTimer = wipeTimerMax;
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

    public void ToggleAbout()
    {
        showAbout = !showAbout;
        audioManager.PlayMenuSound();
        if (showAbout)
            HUDAboutText.GetComponent<MoveNormal>().MoveUp();
        else
            HUDAboutText.GetComponent<MoveNormal>().MoveDown();
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
        HUDControls.text = Globals.ControlsOn ? "D-pad: ON" : "D-pad: OFF";
        Globals.SaveIntToPlayerPrefs(Globals.ControlsPlayerPrefsKey, Globals.ControlsOn ? 1 : 0);
    }

    public void ToggleDifficulty()
    {
        Globals.EasyMode = !Globals.EasyMode;
        audioManager.PlayMenuSound();
        HUDEasyMode.text = Globals.EasyMode ? "Mode: EASY" : "Mode: NORMAL";
        Globals.SaveIntToPlayerPrefs(Globals.EasyModePlayerPrefsKey, Globals.EasyMode ? 1 : 0);
    }

    public void SelectPlayer(int player)
    {
        if (Globals.CharacterUnlockStates[player] == 1)
        {
            audioManager.PlayMenuSound();

            Globals.CurrentPlayerType = (Globals.PlayerTypes)player;

            HUDDialogBox.GetComponent<MoveNormal>().MoveDown();
            HUDCharacterSelect.GetComponent<MoveNormal>().MoveUp();

            HUDDialogBoxText.text = Globals.GetPlayerName() + ": " + dialog1[dialogNum];

            HUDDialogPlayer.GetComponent<Image>().sprite = HUDPlayerSprites[(int)Globals.CurrentPlayerType];
        }
        else
        {
            if (Globals.Coins >= 100)
            {
                audioManager.PlayBuyCharacterSound();
                Globals.Coins = Globals.Coins - 100;
                Globals.SaveIntToPlayerPrefs(Globals.CoinsPlayerPrefsKey, Globals.Coins);
                UpdateCoins();
                Globals.UnlockCharacter(player);
                HUDUnlockBanners[player].SetActive(false);
                HUDCharacterSelectImages[player].GetComponent<Image>().color = new Color(1f, 1f, 1f);
            }
            else
            {
                audioManager.PlayCantBuyCharacterSound();
            }
        }
    }

}
