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

    float[] yPositions = {8f, 3.3f, 1.575f, -0.15f, -1.875f, -3.6f};
    float yMovementThreshold = 5f;
    bool yMovementComplete = false;
    float yFinal = 0;
    int yDir = 0;
    float bounceTimer = 0;
    float bounceTimerMax = 1f;

    float shootTimer = .5f;
    float shootTimerMax = 2f;

    float screenRightEdge = 15f;

    public enum EnemyType {
        Fish,
        FishDown,
        FishUp,
        FishMiddle,
        FishBounce,
        Diver,
        Mollusk,
        GunMollusk,
        GunFish,
        GunFishDown,
        GunFishUp,
        GunFishMiddle,
        GunFishBounce,
        None
    }
    public EnemyType enemyType = EnemyType.Fish;

    public bool isLastInWave;

    public bool isLastInLevel;

    public float extraXmovement = 0f;

    private bool isDropping;
    private float minDropY = -3.6f;

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
            yMovementComplete = true;
        }
        else if (enemyType == EnemyType.FishDown)
        {
            extraXmovement = 2f;
            yFinal = yPositions[yPositions.Length - 1];
            yDir = -1;
        }
        else if (enemyType == EnemyType.FishUp)
        {
            extraXmovement = 2f;
            yFinal = yPositions[1];
            yDir = 1;
        }
        else if (enemyType == EnemyType.FishMiddle)
        {
            extraXmovement = 2f;
            yFinal = yPositions[3];
        }
        else if (enemyType == EnemyType.FishBounce)
        {
            extraXmovement = 2f;
            yFinal = yPositions[1];
            yDir = 1;
            yMovementThreshold = 8f;
        }
        else if (enemyType == EnemyType.GunFish)
        {
            points = 200;
            extraXmovement = 2f;
            yMovementComplete = true;
        }
        else if (enemyType == EnemyType.GunFishDown)
        {
            points = 200;
            extraXmovement = 2f;
            yFinal = yPositions[yPositions.Length - 1];
            yDir = -1;
        }
        else if (enemyType == EnemyType.GunFishUp)
        {
            points = 200;
            extraXmovement = 2f;
            yFinal = yPositions[1];
            yDir = 1;
        }
        else if (enemyType == EnemyType.GunFishMiddle)
        {
            points = 200;
            extraXmovement = 2f;
            yFinal = yPositions[3];
        }
        else if (enemyType == EnemyType.GunFishBounce)
        {
            points = 200;
            extraXmovement = 2f;
            yFinal = yPositions[1];
            yDir = 1;
            yMovementThreshold = 8f;
        }
        else if (enemyType == EnemyType.GunMollusk)
        {
            points = 150;
            extraXmovement = 1f;
            yMovementComplete = true;
        }
        else if (enemyType == EnemyType.Mollusk)
        {
            extraXmovement = 1f;
            yMovementComplete = true;
        }
        else if (enemyType == EnemyType.Diver)
        {
            points = 150;
            extraXmovement = 1f;
            yMovementThreshold = 8f;
            yFinal = minY;
            yDir = -1;
        }
        else if (enemyType == EnemyType.None)
        {
            extraXmovement = 1f;
            yMovementComplete = true;
        }
    }

    void Start()
    {
        if (enemyType == EnemyType.GunFishMiddle || enemyType == EnemyType.FishMiddle)
        {
            if (this.transform.localPosition.y > yPositions[3])
                yDir = -1;
            else
                yDir = 1;
        }
    }

    public void SetExtraXMovement(float val)
    {
        extraXmovement = val;
    }

    public void Drop()
    {
        isDropping = true;
    }

    void Update()
    {
        if (this.transform.position.x <= minX || this.transform.position.y <= minY)
            Destroy(this.gameObject);

        if (Globals.CurrentGameState == Globals.GameState.Playing)
        {
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
        }

        if ((enemyType == EnemyType.GunMollusk || enemyType == EnemyType.GunFish
             || enemyType == EnemyType.GunFishDown || enemyType == EnemyType.GunFishUp
             || enemyType == EnemyType.GunFishMiddle || enemyType == EnemyType.GunFishBounce)
             && this.transform.position.x <= screenRightEdge && isActive)
        {
            shootTimer -= Time.deltaTime;
            if (shootTimer <= 0)
            {
                ShootBullet();
                shootTimer = Mathf.Max(.5f, shootTimerMax - (Globals.ScrollSpeed.x - 1f) / 2f);
            }
        }

        if (!yMovementComplete && this.transform.localPosition.x < yMovementThreshold && yDir == -1 && this.transform.localPosition.y <= yFinal)
        {
            this.transform.localPosition = new Vector3(this.transform.localPosition.x, yFinal, this.transform.localPosition.z);
            yMovementComplete = true;
            if (enemyType == EnemyType.GunFishBounce || enemyType == EnemyType.FishBounce)
            {
                bounceTimer = bounceTimerMax;
                yFinal = yPositions[1];
                yDir = 1;
            }
        }
        else if (!yMovementComplete && this.transform.localPosition.x < yMovementThreshold && yDir == 1 && this.transform.localPosition.y >= yFinal)
        {
            this.transform.localPosition = new Vector3(this.transform.localPosition.x, yFinal, this.transform.localPosition.z);
            yMovementComplete = true;
            if (enemyType == EnemyType.GunFishBounce || enemyType == EnemyType.FishBounce)
            {
                bounceTimer = bounceTimerMax;
                yFinal = yPositions[yPositions.Length - 1];
                yDir = -1;
            }
        }

        if (bounceTimer > 0)
        {
            bounceTimer -= Time.deltaTime;
            if (bounceTimer < 0)
            {
                yMovementComplete = false;
            }
        }
    }

    public void ShootBullet()
    {
        if (Globals.CurrentGameState == Globals.GameState.Playing && !player.IsInDisguise())
        {
            float baseSpeed = Globals.ScrollSpeed.x * Globals.ScrollDirection.x;
            GameObject bulletGameObject = (GameObject)Instantiate(BulletPrefab, Muzzle.transform.position, Quaternion.identity, bulletContainer.transform);
            bulletGameObject.GetComponent<Rigidbody2D>().velocity = enemyType == EnemyType.GunMollusk
                ? new Vector2(baseSpeed - 4f, baseSpeed * -1f + 4f)
                : new Vector2(baseSpeed - 6f, 0);
        }
    }

    void FixedUpdate()
    {
        if (Globals.CurrentGameState == Globals.GameState.Playing || Globals.CurrentGameState == Globals.GameState.ShowScore)
        {
            float extraYmovement = 0f;
            float baseSpeed = Globals.ScrollSpeed.x * Globals.ScrollDirection.x;
            if (enemyType == EnemyType.Diver && this.transform.localPosition.x < yMovementThreshold)
                extraYmovement = baseSpeed - 1f;
            else if (this.transform.localPosition.y > yFinal && this.transform.localPosition.x < yMovementThreshold && !yMovementComplete)
                extraYmovement = -4f + baseSpeed;
            else if (this.transform.localPosition.y < yFinal && this.transform.localPosition.x < yMovementThreshold && !yMovementComplete)
                extraYmovement = 4f - baseSpeed;
            if (enemyType == EnemyType.GunFishBounce || enemyType == EnemyType.FishBounce)
                extraYmovement = extraYmovement * 3f;

            Vector2 movement = new Vector2(0, 0);
            if (isDropping)
            {
                movement = new Vector2(0, -10f);
                if (this.transform.localPosition.y <= minDropY)
                {
                    isDropping = false;
                    this.transform.localPosition = new Vector2(this.transform.localPosition.x, minDropY);
                }
            }
            else if (!isAlive)
            {
                movement = new Vector2 (0, -15f);
            }
            else
                movement = new Vector2 (Globals.ScrollSpeed.x * Globals.ScrollDirection.x + extraXmovement * Globals.ScrollDirection.x, extraYmovement);

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
