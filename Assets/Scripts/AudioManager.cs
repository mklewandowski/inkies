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
    AudioClip EnemyNoHurtSound;
    [SerializeField]
    AudioClip EnemyStompSound;
    [SerializeField]
    AudioClip ShootSound;
    [SerializeField]
    AudioClip GameOverSound;
    [SerializeField]
    AudioClip HitSound;
    [SerializeField]
    AudioClip CoinSound;
    [SerializeField]
    AudioClip PowerUpSound;
    [SerializeField]
    AudioClip CantBuySound;
    [SerializeField]
    AudioClip BuySound;
    [SerializeField]
    AudioClip LevelCompleteSound;
    [SerializeField]
    AudioClip BossAppearsSound;

    [SerializeField]
    AudioClip WinMusic;
    [SerializeField]
    AudioClip InkiesMusic;

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

    public void PlayGameMusic()
    {
        audioSource.clip = InkiesMusic;
        audioSource.Play();
    }

    public void PlayWinMusic()
    {
        audioSource.clip = WinMusic;
        audioSource.Play();
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

    public void PlayEnemyNoHurtSound()
    {
        if (Globals.AudioOn)
            audioSource.PlayOneShot(EnemyNoHurtSound, 1f);
    }

    public void PlayEnemyStompSound()
    {
        if (Globals.AudioOn)
            audioSource.PlayOneShot(EnemyStompSound, 1f);
    }

    public void PlayShootSound()
    {
        if (Globals.AudioOn)
            audioSource.PlayOneShot(ShootSound, 1f);
    }

    public void PlayGameOverSound()
    {
        if (Globals.AudioOn)
            audioSource.PlayOneShot(GameOverSound, 1f);
    }

    public void PlayHitSound()
    {
        if (Globals.AudioOn)
            audioSource.PlayOneShot(HitSound, 1f);
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

    public void PlayLevelCompleteSound()
    {
        if (Globals.AudioOn)
            audioSource.PlayOneShot(LevelCompleteSound, 1f);
    }

    public void PlayBossAppearsSound()
    {
        if (Globals.AudioOn)
            audioSource.PlayOneShot(BossAppearsSound, 1f);
    }
}
