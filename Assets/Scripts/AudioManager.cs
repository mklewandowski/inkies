using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource audioSource;

    [SerializeField]
    AudioClip MenuSound;
    [SerializeField]
    AudioClip StartSound;
    [SerializeField]
    AudioClip EnemyZappedSound;
    [SerializeField]
    AudioClip ShootSound;
    [SerializeField]
    AudioClip GameOver;
    [SerializeField]
    AudioClip CoinSound;
    [SerializeField]
    AudioClip PowerUpSound;
    [SerializeField]
    AudioClip CantBuySound;
    [SerializeField]
    AudioClip BuySound;

    void Awake()
    {
        audioSource = this.GetComponent<AudioSource>();
        int audioOn = Globals.LoadIntFromPlayerPrefs(Globals.AudioPlayerPrefsKey, 1);
        int musicOn = Globals.LoadIntFromPlayerPrefs(Globals.MusicPlayerPrefsKey, 1);
        Globals.AudioOn = audioOn == 1 ? true : false;
        Globals.MusicOn = musicOn == 1 ? true : false;
        if (Globals.MusicOn)
            audioSource.Play();
    }

    public void StartMusic()
    {
        audioSource.Play();
    }
    public void StopMusic()
    {
        audioSource.Stop();
    }

    public void PlayMenuSound()
    {
        if (Globals.AudioOn)
            audioSource.PlayOneShot(MenuSound, 1f);
    }

    public void PlayStartSound()
    {
        if (Globals.AudioOn)
            audioSource.PlayOneShot(StartSound, 1f);
    }

    public void PlayEnemyZappedSound()
    {
        if (Globals.AudioOn)
            audioSource.PlayOneShot(EnemyZappedSound, 1f);
    }

    public void PlayShootSound()
    {
        if (Globals.AudioOn)
            audioSource.PlayOneShot(ShootSound, 1f);
    }

    public void PlayGameOver()
    {
        if (Globals.AudioOn)
            audioSource.PlayOneShot(GameOver, 1f);
    }

    public void PlayCoinSound()
    {
        if (Globals.AudioOn)
            audioSource.PlayOneShot(CoinSound, 1f);
    }

    public void PlayPowerUpSound()
    {
        if (Globals.AudioOn)
            audioSource.PlayOneShot(PowerUpSound, 1f);
    }

    public void PlayBuyCharacterSound()
    {
        if (Globals.AudioOn)
            audioSource.PlayOneShot(BuySound, 1f);
    }

    public void PlayCantBuyCharacterSound()
    {
        if (Globals.AudioOn)
            audioSource.PlayOneShot(CantBuySound, 1f);
    }
}
