using UnityEngine;

public class Globals
{
    // game scroll speed
    public static Vector3 ScrollSpeed = new Vector3(0, 0, 0);
    public static float minSpeed = 1f;
    public static float maxSpeed = 45f;

    // moving direction
    public static Vector3 ScrollDirection = new Vector3(-1f, 0, 0);

    public enum GameState {
        TitleScreen,
        Starting,
        IntroDialog,
        Ready,
        Playing,
        ShowScore,
        Restart
    }
    public static GameState CurrentGameState = GameState.TitleScreen;

    public enum PlayerTypes {
        Sally,
        Tom,
        Welley,
        Stan,
        Gen,
        Jerry,
        Mario,
        Luigi
    }
    public static PlayerTypes CurrentPlayerType = PlayerTypes.Sally;

    // keep track of scoring
    public static int BestScore = 0;
    public static int CurrentScore = 0;

    public const string BestScorePlayerPrefsKey = "BestScore";

    // keep track of coins
    public static int Coins = 0;

    public const string CoinsPlayerPrefsKey = "Coins";

    // audio and music
    public static bool AudioOn;
    public static bool MusicOn;

    public const string AudioPlayerPrefsKey = "Audio";
    public const string MusicPlayerPrefsKey = "Music";

    public static bool ControlsOn;

    public const string ControlsPlayerPrefsKey = "Controls";

    public static bool EasyMode;

    public const string EasyModePlayerPrefsKey = "EasyMode";

    public static int MaxCharacters = 40;
    public static int[] CharacterUnlockStates = new int[MaxCharacters];
    public const string CharacterUnlockPlayerPrefsKey = "Vehicle";

    public static void LoadCharacterUnlockStatesFromPlayerPrefs()
    {
        for (int x = 0; x < MaxCharacters; x++)
        {
            int unlock = LoadIntFromPlayerPrefs(CharacterUnlockPlayerPrefsKey + x.ToString());
            CharacterUnlockStates[x] = unlock;
        }
        CharacterUnlockStates[0] = 1;
        CharacterUnlockStates[1] = 1;
    }

    public static void UnlockCharacter(int num)
    {
        CharacterUnlockStates[num] = 1;
        SaveIntToPlayerPrefs(CharacterUnlockPlayerPrefsKey + num.ToString(), 1);
    }

    public static void SaveIntToPlayerPrefs(string key, int val)
    {
        PlayerPrefs.SetInt(key, val);
    }
    public static int LoadIntFromPlayerPrefs(string key, int defaultVal = 0)
    {
        int val = PlayerPrefs.GetInt(key, defaultVal);
        return val;
    }

    public static string GetPlayerName()
    {
        if (CurrentPlayerType == PlayerTypes.Sally)
            return "SALLY";
        else if (CurrentPlayerType == PlayerTypes.Tom)
            return "TOM";
        else if (CurrentPlayerType == PlayerTypes.Welley)
            return "WELLEY";
        else if (CurrentPlayerType == PlayerTypes.Stan)
            return "STAN";
        else if (CurrentPlayerType == PlayerTypes.Gen)
            return "GEN";
        else if (CurrentPlayerType == PlayerTypes.Jerry)
            return "JERRY";
        else if (CurrentPlayerType == PlayerTypes.Mario)
            return "MARIO";
        else if (CurrentPlayerType == PlayerTypes.Luigi)
            return "LUIGI";
        else
            return "SALLY";
    }

}
