using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    AudioManager audioManager;
    SceneManager sceneManager;
    Player player;

    [SerializeField]
    GameObject Muzzle;

    [SerializeField]
    GameObject BulletPrefab;
    GameObject bulletContainer;

    bool isActive = true;

    bool isAlive = true;

    float minX = -20f;
    float minY = -20f;

    float maxYMovementPos = 0f;
    float minYMovementPos = 0f;
    float movementYDir = 1f;

    float shootTimer = .5f;
    float shootTimerMax = 2f;

    float screenRightEdge = 15f;

    public enum EnemyType {
        Fish,
        Diver,
        Mollusk,
        GunMollusk,
        GunFish,
        GunFishBounce,
        GunFishHard,
        None
    }
    public EnemyType enemyType = EnemyType.Fish;

    public bool isLastInWave;

    public bool isLastInLevel;

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
        player = GameObject.Find("Player").GetComponent<Player>();

        if (enemyType == EnemyType.Fish)
        {
            extraXmovement = 2f;
            maxYMovementPos = this.transform.position.y + .5f;
            minYMovementPos = this.transform.position.y - .5f;
        }
        else if (enemyType == EnemyType.GunFish)
        {
            points = 150;
            extraXmovement = 2f;
        }
        else if (enemyType == EnemyType.GunFishBounce)
        {
            points = 200;
            extraXmovement = 2f;
            maxYMovementPos = this.transform.position.y + .5f;
            minYMovementPos = this.transform.position.y - .5f;
        }
        else if (enemyType == EnemyType.GunFishHard)
        {
            points = 250;
            extraXmovement = 2f;
            maxYMovementPos = this.transform.position.y + 1f;
            minYMovementPos = this.transform.position.y - 1f;
        }
        else if (enemyType == EnemyType.GunMollusk)
        {
            points = 200;
            extraXmovement = 1f;
        }
        else if (enemyType == EnemyType.Mollusk)
        {
            extraXmovement = 1f;
        }
        else if (enemyType == EnemyType.Diver)
        {
            points = 200;
            extraXmovement = 1f;
        }
        else if (enemyType == EnemyType.None)
        {
            extraXmovement = 1f;
        }
    }

    public void SetExtraXMovement(float val)
    {
        extraXmovement = val;
    }

    void Update()
    {
        if (this.transform.position.x <= minX || this.transform.position.y <= minY)
            Destroy(this.gameObject);

        if (isLastInWave && this.transform.position.x <= -8f)
        {
            isLastInWave = false;
            sceneManager.SpawnWave();
        }

        if (isLastInLevel && this.transform.position.x <= -8f)
        {
            isLastInLevel = false;
            sceneManager.LevelComplete();
        }

        if ((enemyType == EnemyType.GunMollusk || enemyType == EnemyType.GunFish) && this.transform.position.x <= screenRightEdge && isActive)
        {
            shootTimer -= Time.deltaTime;
            if (shootTimer <= 0)
            {
                ShootBullet();
                shootTimer = Mathf.Max(.5f, shootTimerMax - (Globals.ScrollSpeed.x - 1f) / 2f);
            }
        }
    }

    public void ShootBullet()
    {
        if (Globals.CurrentGameState == Globals.GameState.Playing && !player.IsInDisguise())
        {
            float baseSpeed = Globals.ScrollSpeed.x * Globals.ScrollDirection.x;
            GameObject bulletGameObject = (GameObject)Instantiate(BulletPrefab, Muzzle.transform.position, Quaternion.identity, bulletContainer.transform);
            bulletGameObject.GetComponent<Rigidbody2D>().velocity = enemyType == EnemyType.GunFish
                ? new Vector2(baseSpeed - 6f, 0)
                : new Vector2(baseSpeed - 4f, baseSpeed * -1f + 4f);
        }
    }

    void FixedUpdate()
    {
        if (Globals.CurrentGameState == Globals.GameState.Playing || Globals.CurrentGameState == Globals.GameState.ShowScore)
        {
            float extraYmovement = 0f;
            float baseSpeed = Globals.ScrollSpeed.x * Globals.ScrollDirection.x;
            if (enemyType == EnemyType.Diver && this.transform.localPosition.x < 8f)
                extraYmovement = baseSpeed - 1f;
            else if ((enemyType == EnemyType.Fish || enemyType == EnemyType.GunFish) && isAlive)
            {
                if (this.transform.position.y >= maxYMovementPos)
                    movementYDir = 1f;
                else if (this.transform.position.y <= minYMovementPos)
                    movementYDir = -1f;
                extraYmovement = baseSpeed * movementYDir * .5f;
            }

            Vector2 movement = new Vector2 (Globals.ScrollSpeed.x * Globals.ScrollDirection.x + extraXmovement * Globals.ScrollDirection.x, extraYmovement);

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
            KillEnemy(collider);
        }
    }

    public void KillEnemy(Collider2D collider)
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
