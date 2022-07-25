using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    AudioManager audioManager;
    SceneManager sceneManager;

    bool isActive = true;

    bool isAlive = true;

    float minX = -20f;
    float minY = -20f;

    public enum EnemyType {
        Fish,
        Diver,
        Mollusk,
        GunMollusk
    }
    public EnemyType enemyType = EnemyType.Fish;

    int points = 100;

    void Awake()
    {
        audioManager = GameObject.Find("SceneManager").GetComponent<AudioManager>();
        sceneManager = GameObject.Find("SceneManager").GetComponent<SceneManager>();

        if (enemyType == EnemyType.GunMollusk)
            points = 200;
        else if (enemyType == EnemyType.Diver)
            points = 200;
    }

    void Update()
    {
        if (this.transform.position.x <= minX || this.transform.position.y <= minY)
            Destroy(this.gameObject);
    }

    void FixedUpdate()
    {
        if (Globals.CurrentGameState == Globals.GameState.Playing || Globals.CurrentGameState == Globals.GameState.ShowScore)
        {
            float extraXmovement = 0f;
            if (enemyType == EnemyType.Fish)
                extraXmovement = 2f;
            else if (enemyType == EnemyType.Mollusk)
                extraXmovement = 1f;
            else if (enemyType == EnemyType.Diver)
                extraXmovement = 1f;

            float extraYmovement = 0f;
            if (enemyType == EnemyType.Diver && this.transform.localPosition.x < 8f)
                extraYmovement = -2f;

            Vector2 movement = new Vector2 (Globals.ScrollSpeed.x * Globals.ScrollDirection.x + extraXmovement * Globals.ScrollDirection.x, 0 + extraYmovement);

            if (!isAlive)
            {
                movement = new Vector2 (0, -15f);
            }

            this.GetComponent<Rigidbody2D>().velocity = movement;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Player player = collider.gameObject.GetComponent<Player>();
        InkBullet bullet = collider.gameObject.GetComponent<InkBullet>();
        if (player != null && Globals.CurrentGameState == Globals.GameState.Playing && isActive)
        {
            audioManager.PlayGameOver();

            this.GetComponent<Collider2D>().enabled = false;

            isActive = false;

            sceneManager.GameOver();
        }
        else if (bullet != null && Globals.CurrentGameState == Globals.GameState.Playing && isActive)
        {
            audioManager.PlayEnemyZappedSound();

            this.GetComponent<Collider2D>().enabled = false;

            this.GetComponent<SpriteRenderer>().color = Color.black;

            isActive = false;
            isAlive = false;

            Destroy(collider.gameObject);

            sceneManager.IncrementScore(points);
        }
    }

}
