using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public enum PowerupType {
        Invincible,
        SuperInk,
        Disguise
    }
    public PowerupType powerupType = PowerupType.SuperInk;

    AudioManager audioManager;
    SceneManager sceneManager;
    bool isActive = true;
    float minX = -20f;

    void Awake()
    {
        audioManager = GameObject.Find("SceneManager").GetComponent<AudioManager>();
        sceneManager = GameObject.Find("SceneManager").GetComponent<SceneManager>();
    }

    void Update()
    {
        if (Globals.CurrentGameState == Globals.GameState.Restart || this.transform.position.x < minX)
        {
            Destroy(this.gameObject);
        }
    }

    void FixedUpdate()
    {
        if (Globals.CurrentGameState == Globals.GameState.Ready || Globals.CurrentGameState == Globals.GameState.Playing || Globals.CurrentGameState == Globals.GameState.ShowScore)
        {
            Vector3 movement = new Vector3 (Globals.ScrollSpeed.x * Globals.ScrollDirection.x, 0, 0);
            this.GetComponent<Rigidbody2D>().velocity = movement;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Player player = collider.gameObject.GetComponent<Player>();
        if (player != null && Globals.CurrentGameState == Globals.GameState.Playing && isActive)
        {
            isActive = false;

            audioManager.PlayPowerUpSound();
            player.GetPowerUp(powerupType);
            sceneManager.GetPowerUp(powerupType);

            Destroy(this.gameObject);
        }
    }
}
