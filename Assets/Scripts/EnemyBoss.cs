using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoss : MonoBehaviour
{
    public enum BossState {
        Bounce,
        BottomShoot,
        Shake,
        Drop,
        Dead,
        Idle
    }
    BossState currentBossState = BossState.Bounce;

    AudioManager audioManager;
    SceneManager sceneManager;

    [SerializeField]
    GameObject EnemyContainer;
    [SerializeField]
    GameObject Muzzle;
    [SerializeField]
    GameObject Body;
    [SerializeField]
    GameObject Head;
    [SerializeField]
    GameObject MolluskPrefab;
    float[] molluskSpawnLocations = {2f, 0f, -2f};

    [SerializeField]
    GameObject BulletPrefab;
    GameObject bulletContainer;
    float shootTimer = .5f;
    float bounceShootTimerMax = .2f;
    float bottomShootTimerMax = 2f;

    int hits = 50;
    int maxHits = 50;
    float hitTimer = 0f;

    float maxY = 2f;
    float minY = -1f;
    float stompY = -1.9f;
    bool movingDown = false;
    float moveSpeed = 2.5f;
    float dropSpeed = 30f;
    int bounceCount = 0;
    int maxBounce = 3;
    float shakeTimer = 0;
    float shakeTimerMax = 3f;
    float rotateTimer = 0;
    float rotateTimerMax = .025f;
    float bottomTimer = 0f;
    float bottomTimerMax = 3f;

    void Start()
    {
        bulletContainer = GameObject.Find("Bullets");
        audioManager = GameObject.Find("SceneManager").GetComponent<AudioManager>();
        sceneManager = GameObject.Find("SceneManager").GetComponent<SceneManager>();
    }

    public void Reset()
    {
        hits = maxHits;
        currentBossState = BossState.Bounce;
        transform.localPosition = new Vector3(4.5f, 0, 0);
        hitTimer = 0;
        this.GetComponent<SpriteRenderer>().color = Color.white;
        this.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        Head.GetComponent<Collider2D>().enabled = true;
        Body.GetComponent<Collider2D>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (hitTimer > 0 && currentBossState != BossState.Dead)
        {
            hitTimer -= Time.deltaTime;
            if (hitTimer < 0)
                this.GetComponent<SpriteRenderer>().color = Color.white;
        }
        if (currentBossState == BossState.Bounce)
        {
            shootTimer -= Time.deltaTime;
            if (shootTimer <= 0)
            {
                ShootBullet(0);
                shootTimer = bounceShootTimerMax;
            }
            if (movingDown)
            {
                Vector3 newpos = this.transform.localPosition;
                newpos.y = Mathf.Max (minY, newpos.y - moveSpeed * Time.deltaTime);
                this.transform.localPosition = newpos;
                if (newpos.y == minY)
                {
                    movingDown = false;
                    currentBossState = BossState.BottomShoot;
                    shootTimer = bottomShootTimerMax;
                    bottomTimer = bottomTimerMax;
                }
            }
            else
            {
                Vector3 newpos = this.transform.localPosition;
                newpos.y = Mathf.Min (maxY, newpos.y + moveSpeed * Time.deltaTime);
                this.transform.localPosition = newpos;
                if (newpos.y == maxY)
                {
                    bounceCount++;
                    if (bounceCount == maxBounce)
                    {
                        bounceCount = 0;
                        currentBossState = BossState.Shake;
                        shakeTimer = shakeTimerMax;
                    }
                    movingDown = true;
                }
            }
        }
        else if (currentBossState == BossState.BottomShoot)
        {
            shootTimer -= Time.deltaTime;
            if (shootTimer <= 0)
            {
                ShootBullet(0);
                ShootBullet(1f);
                ShootBullet(-1f);
                shootTimer = bottomShootTimerMax;
            }
            bottomTimer -= Time.deltaTime;
            if (bottomTimer < 0)
            {
                shootTimer = bounceShootTimerMax;
                currentBossState = BossState.Bounce;
            }
        }
        else if (currentBossState == BossState.Shake)
        {
            shakeTimer -= Time.deltaTime;
            if (shakeTimer < 0)
            {
                currentBossState = BossState.Drop;
                this.transform.localEulerAngles = new Vector3(0, 0, 0);
            }
            rotateTimer -= Time.deltaTime;
            if (rotateTimer < 0)
            {
                this.transform.localEulerAngles = new Vector3(0, 0, Random.Range(-5f, 5f));
                rotateTimer = rotateTimerMax;
            }
        }
        else if (currentBossState == BossState.Drop)
        {
            Vector3 newpos = this.transform.localPosition;
            newpos.y = Mathf.Max (stompY, newpos.y - dropSpeed * Time.deltaTime);
            this.transform.localPosition = newpos;
            if (newpos.y == stompY)
            {
                audioManager.PlayEnemyStompSound();
                Camera.main.GetComponent<CameraShake>().StartShake();
                currentBossState = BossState.Bounce;
                movingDown = false;

                for (int x = 0; x < molluskSpawnLocations.Length; x++)
                {
                    GameObject enemyGO = (GameObject)Instantiate(MolluskPrefab, new Vector3(molluskSpawnLocations[x], 12f + x, 0), MolluskPrefab.transform.rotation, EnemyContainer.transform);
                    enemyGO.GetComponent<Enemy>().Drop();
                }
            }
        }
        if (this.transform.localPosition.y < -15f)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
            currentBossState = BossState.Idle;
        }
    }

    void FixedUpdate()
    {
        if (Globals.CurrentGameState == Globals.GameState.Playing || Globals.CurrentGameState == Globals.GameState.ShowScore)
        {
            Vector2 movement = new Vector2 (0, 0);

            if (currentBossState == BossState.Dead)
            {
                movement = new Vector2 (0, -15f);
            }

            this.GetComponent<Rigidbody2D>().velocity = movement;
        }
    }

    public void ShootBullet(float yVel)
    {
        if (Globals.CurrentGameState == Globals.GameState.Playing)
        {
            float baseSpeed = Globals.ScrollSpeed.x * Globals.ScrollDirection.x;
            GameObject bulletGameObject = (GameObject)Instantiate(BulletPrefab, Muzzle.transform.position, Quaternion.identity, bulletContainer.transform);
            bulletGameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(baseSpeed - 6f, yVel);
        }
    }

    public void HitHead()
    {
        if (currentBossState == BossState.Dead)
            return;

        hits--;
        audioManager.PlayEnemyZappedSound();
        if (hits <= 0)
            KillEnemy();
        else
        {
            this.GetComponent<SpriteRenderer>().color = new Color (137f / 255f, 165f / 255f, 118f / 255f);
            hitTimer = .15f;
        }
    }

    public void HitBody()
    {
        if (currentBossState == BossState.Dead)
            return;

        audioManager.PlayEnemyNoHurtSound();
    }

    public void KillEnemy()
    {
        Head.GetComponent<Collider2D>().enabled = false;
        Body.GetComponent<Collider2D>().enabled = false;

        this.GetComponent<SpriteRenderer>().color = Color.black;

        currentBossState = BossState.Dead;

        sceneManager.IncrementScore(1000);
        sceneManager.WinGame();
    }
}
