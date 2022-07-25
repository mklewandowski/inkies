using UnityEngine;

public class Globals
{
    // game scroll speed
    public static Vector3 ScrollSpeed = new Vector3(0, 0, 0);
    public static float minSpeed = 3f;
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

    // audio and music
    public static bool AudioOn;
    public static bool MusicOn;

    public const string AudioPlayerPrefsKey = "Audio";
    public const string MusicPlayerPrefsKey = "Music";

    public static void SaveIntToPlayerPrefs(string key, int val)
    {
        PlayerPrefs.SetInt(key, val);
    }
    public static int LoadIntFromPlayerPrefs(string key, int defaultVal = 0)
    {
        int val = PlayerPrefs.GetInt(key, defaultVal);
        return val;
    }

}
