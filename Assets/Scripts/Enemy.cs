using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    AudioManager audioManager;
    SceneManager sceneManager;

    [SerializeField]
    GameObject Muzzle;

    [SerializeField]
    GameObject BulletPrefab;
    GameObject bulletContainer;

    bool isActive = true;

    bool isAlive = true;

    float minX = -20f;
    float minY = -20f;

    float shootTimer = 1f;
    float shootTimerMax = 2f;

    float screenRightEdge = 15f;

    public enum EnemyType {
        Fish,
        Diver,
        Mollusk,
        GunMollusk,
        GunFish,
        None
    }
    public EnemyType enemyType = EnemyType.Fish;

    public bool isLastInWave;

    public float extraXmovement = 0f;

    int points = 100;

    void Awake()
    {
        float aspect = (float)Screen.width / Screen.height;
        float worldHeight = Camera.main.orthographicSize * 2;
        float worldWidth = worldHeight * aspect;
        screenRightEdge = worldWidth / 2f;

        bulletContainer = GameObject.Find("Bullets");
        audioManager = GameObject.Find("SceneManager").GetComponent<AudioManager>();
        sceneManager = GameObject.Find("SceneManager").GetComponent<SceneManager>();

        if (enemyType == EnemyType.GunMollusk)
            points = 200;
        else if (enemyType == EnemyType.Diver)
            points = 200;
        else if (enemyType == EnemyType.GunFish)
            points = 200;

        if (enemyType == EnemyType.Fish)
            extraXmovement = 2f;
        else if (enemyType == EnemyType.GunFish)
            extraXmovement = 2f;
        else if (enemyType == EnemyType.GunMollusk)
            extraXmovement = 1f;
        else if (enemyType == EnemyType.Mollusk)
            extraXmovement = 1f;
        else if (enemyType == EnemyType.Diver)
            extraXmovement = 1f;
        else if (enemyType == EnemyType.None)
            extraXmovement = 1f;
    }

    public void SetExtraXMovement(float val)
    {
        extraXmovement = val;
    }

    void Update()
    {
        if (this.transform.position.x <= minX || this.transform.position.y <= minY)
            Destroy(this.gameObject);

        if (isLastInWave && this.transform.position.x <= 0)
        {
            isLastInWave = false;
            sceneManager.SpawnWave();
        }

        if ((enemyType == EnemyType.GunMollusk || enemyType == EnemyType.GunFish) && this.transform.position.x <= screenRightEdge && isActive)
        {
            shootTimer -= Time.deltaTime;
            if (shootTimer <= 0)
            {
                ShootBullet();
                shootTimer = shootTimerMax;
            }
        }
    }

    public void ShootBullet()
    {
        if (Globals.CurrentGameState == Globals.GameState.Playing)
        {
            GameObject bulletGameObject = (GameObject)Instantiate(BulletPrefab, Muzzle.transform.position, Quaternion.identity, bulletContainer.transform);
            bulletGameObject.GetComponent<Rigidbody2D>().velocity = enemyType == EnemyType.GunFish
                ? new Vector2(-7f, 0)
                : new Vector2(-5f, 5f);
        }
    }

    void FixedUpdate()
    {
        if (Globals.CurrentGameState == Globals.GameState.Playing || Globals.CurrentGameState == Globals.GameState.ShowScore)
        {
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
        Bullet bullet = collider.gameObject.GetComponent<Bullet>();
        if (bullet != null && !bullet.GetComponent<Bullet>().enemyBullet && Globals.CurrentGameState == Globals.GameState.Playing && isActive)
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
