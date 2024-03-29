using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    AudioManager audioManager;
    SceneManager sceneManager;

    [SerializeField]
    GameObject InkBulletPrefab;
    [SerializeField]
    GameObject PresentBulletPrefab;
    [SerializeField]
    GameObject SlimeBulletPrefab;
    [SerializeField]
    GameObject NoteBulletPrefab;
    [SerializeField]
    GameObject BasketballBulletPrefab;
    [SerializeField]
    GameObject MattBulletPrefab;
    [SerializeField]
    GameObject MattBullet2Prefab;
    [SerializeField]
    GameObject VioletBulletPrefab;

    [SerializeField]
    GameObject Muzzle;

    [SerializeField]
    GameObject BulletContainer;

    [SerializeField]
    GameObject PlayerSprite;
    [SerializeField]
    GameObject DisguiseSprite;
    [SerializeField]
    Sprite[] PlayerSprites;
    [SerializeField]
    GameObject[] Stars;

    Vector2 initialPos = new Vector2(-5f, -1f);
    Vector2 bulletMovementVector = new Vector2(10f, 0);
    Vector2 movementVector = new Vector2(0, 0);
    float minX = -5f;
    float maxX = 5f;
    float minY = -3.4f;
    float maxY = 4f;
    bool moveLeft;
    bool moveRight;
    bool moveUp;
    bool moveDown;
    bool moveLeftButton;
    bool moveRightButton;
    bool moveUpButton;
    bool moveDownButton;
    bool shootInkButton;
    float moveSpeed = 6f;

    Vector3 mousePositionOffset;

    Vector3 touchPosition;
    Vector3 direction;
    private Rigidbody2D playerRigidbody;

    float inkCoolDownTimer = 0f;
    float inkCoolDownTimerMax = .25f;

    float superInkTimer = 0f;
    float invincibleTimer = 0f;
    float disguiseTimer = 0f;
    float flashThreshold = 1.5f;
    float hitInvincibleTimer = 0f;

    int bulletType = 0;

    void Awake()
    {
        audioManager = GameObject.Find("SceneManager").GetComponent<AudioManager>();
        sceneManager = GameObject.Find("SceneManager").GetComponent<SceneManager>();

        float aspect = (float)Screen.width / Screen.height;
        float worldHeight = Camera.main.orthographicSize * 2;
        float worldWidth = worldHeight * aspect;

        minX = -1f * worldWidth / 2f;
        maxX = worldWidth / 2f;
        Debug.Log(worldWidth);

        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    public void Reset()
    {
        PlayerSprite.GetComponent<SpriteRenderer>().sprite =  PlayerSprites[(int)Globals.CurrentPlayerType];

        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        this.transform.localPosition = initialPos;
        this.GetComponent<Collider2D>().enabled = true;

        for (int x = 0; x < Stars.Length; x++)
        {
            Stars[x].SetActive(false);
        }

        invincibleTimer = 0;
        superInkTimer = 0;
        disguiseTimer = 0;

        DisguiseSprite.GetComponent<GrowAndShrink>().StopEffect();
        DisguiseSprite.GetComponent<ShrinkAndHide>().StopEffect();
        PlayerSprite.GetComponent<GrowAndShrink>().StopEffect();
        PlayerSprite.GetComponent<ShrinkAndHide>().StopEffect();
        DisguiseSprite.SetActive(false);
        PlayerSprite.GetComponent<SpriteRenderer>().color = Color.white;
        DisguiseSprite.GetComponent<SpriteRenderer>().color = Color.white;
        PlayerSprite.transform.localScale = new Vector3(1f, 1f, 1f);
        PlayerSprite.SetActive(true);
    }

    public void Hit()
    {
        hitInvincibleTimer = 1.5f;
    }

    public void Die()
    {
        this.GetComponent<Collider2D>().enabled = false;
    }

    public void GetPowerUp(PowerUp.PowerupType powerupType)
    {
        if (powerupType == PowerUp.PowerupType.Invincible)
        {
            invincibleTimer = 6f;
            for (int x = 0; x < Stars.Length; x++)
            {
                Stars[x].SetActive(true);
            }
        }
        else if (powerupType == PowerUp.PowerupType.SuperInk)
        {
            superInkTimer = 8f;
        }
        else if (powerupType == PowerUp.PowerupType.Disguise)
        {
            if (disguiseTimer <= 0)
            {
                PlayerSprite.GetComponent<ShrinkAndHide>().StartEffect();
                DisguiseSprite.transform.localScale = new Vector3(.1f, .1f, .1f);
                DisguiseSprite.SetActive(true);
                DisguiseSprite.GetComponent<GrowAndShrink>().StartEffect();
            }
            disguiseTimer = 10f;
        }
    }

    public bool IsInvincible()
    {
        return invincibleTimer > 0;
    }

    public bool IsHitInvincible()
    {
        return hitInvincibleTimer > 0;
    }

    public bool IsInDisguise()
    {
        return disguiseTimer > 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Globals.CurrentGameState == Globals.GameState.Playing)
        {
            UpdateTimers();

            moveLeft = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) || moveLeftButton;
            moveRight = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) || moveRightButton;
            moveUp = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) || moveUpButton;
            moveDown = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S) || moveDownButton;
            movementVector = new Vector2(0, 0);
            if (moveLeft)
                movementVector.x = moveSpeed * -1f;
            else if (moveRight)
                movementVector.x = moveSpeed;
            if (moveUp)
                movementVector.y = moveSpeed;
            else if (moveDown)
                movementVector.y = moveSpeed * -1f;
            if (moveLeft || moveRight || moveUp || moveDown || shootInkButton)
            {
                if (inkCoolDownTimer == 0)
                {
                    ShootInk();
                    inkCoolDownTimer = inkCoolDownTimerMax;
                }
            }
            playerRigidbody.velocity = movementVector;

            if (inkCoolDownTimer > 0)
            {
                inkCoolDownTimer -= Time.deltaTime;
                if (inkCoolDownTimer <= 0)
                    inkCoolDownTimer = 0;
            }

            if (Input.touchCount > 0 && !Globals.ControlsOn)
            {
                Touch touch = Input.GetTouch(0);
                touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                touchPosition.z = 0f;
                direction = (touchPosition - transform.position);
                playerRigidbody.velocity = new Vector2(direction.x, direction.y) * moveSpeed;
                if (touch.phase == TouchPhase.Ended)
                {
                    playerRigidbody.velocity = Vector2.zero;
                }
                if (inkCoolDownTimer == 0)
                {
                    ShootInk();
                    inkCoolDownTimer = inkCoolDownTimerMax;
                }
            }

            KeepInBounds();

            if (Input.GetKeyDown(KeyCode.Space))
                ShootInk();

        }
        else if (Globals.CurrentGameState == Globals.GameState.ShowScore)
        {
            movementVector = new Vector2 (0, -15f);
            this.GetComponent<Rigidbody2D>().velocity = movementVector;
        }
    }

    private void UpdateTimers()
    {
        if (invincibleTimer > 0)
        {
            invincibleTimer -= Time.deltaTime;
            if (invincibleTimer <= 0)
            {
                for (int x = 0; x < Stars.Length; x++)
                {
                    Stars[x].SetActive(false);
                }
                PlayerSprite.GetComponent<SpriteRenderer>().color = Color.white;
            }
            else if (invincibleTimer <= flashThreshold)
            {
                FlashSprite(invincibleTimer, PlayerSprite);
            }
        }
        if (hitInvincibleTimer > 0)
        {
            hitInvincibleTimer -= Time.deltaTime;
            if (hitInvincibleTimer <= 0)
            {
                PlayerSprite.GetComponent<SpriteRenderer>().color = Color.white;
            }
            else if (hitInvincibleTimer <= flashThreshold)
            {
                FlashSprite(hitInvincibleTimer, PlayerSprite);
            }
        }
        if (superInkTimer > 0)
        {
            superInkTimer -= Time.deltaTime;
            if (superInkTimer <= 0)
            {
                PlayerSprite.GetComponent<SpriteRenderer>().color = Color.white;
            }
            else if (superInkTimer <= flashThreshold)
            {
                FlashSprite(superInkTimer, PlayerSprite);
            }
        }
        if (disguiseTimer > 0)
        {
            disguiseTimer -= Time.deltaTime;
            if (disguiseTimer <= 0)
            {
                DisguiseSprite.GetComponent<ShrinkAndHide>().StartEffect();
                PlayerSprite.transform.localScale = new Vector3(.1f, .1f, .1f);
                PlayerSprite.SetActive(true);
                PlayerSprite.GetComponent<GrowAndShrink>().StartEffect();
                DisguiseSprite.GetComponent<SpriteRenderer>().color = Color.white;
            }
            else if (disguiseTimer <= flashThreshold)
            {
                FlashSprite(disguiseTimer, DisguiseSprite);
            }
        }
    }

    private void FlashSprite(float flashTime, GameObject flashSprite)
    {
        flashSprite.GetComponent<SpriteRenderer>().color = (int)(flashTime * 10f) % 2 == 0 ? Color.white : new Color (137f / 255f, 165f / 255f, 118f / 255f);
    }

    private void KeepInBounds()
    {
        if (transform.localPosition.x > maxX)
        {
            Vector2 boundedPos = new Vector2 (maxX, transform.localPosition.y);
            transform.localPosition = boundedPos;
        }
        if (transform.localPosition.x < minX)
        {
            Vector2 boundedPos = new Vector2 (minX, transform.localPosition.y);
            transform.localPosition = boundedPos;
        }
        if (transform.localPosition.y > maxY)
        {
            Vector2 boundedPos = new Vector2 (transform.localPosition.x, maxY);
            transform.localPosition = boundedPos;
        }
        if (transform.localPosition.y < minY)
        {
            Vector2 boundedPos = new Vector2 (transform.localPosition.x, minY);
            transform.localPosition = boundedPos;
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDown()
    {
        if (Globals.CurrentGameState == Globals.GameState.Playing && !Globals.ControlsOn)
        {
            mousePositionOffset = gameObject.transform.position - GetMouseWorldPosition();
            ShootInk();
            inkCoolDownTimer = inkCoolDownTimerMax;
        }
    }

    private void OnMouseDrag()
    {
        if (Globals.CurrentGameState == Globals.GameState.Playing && !Globals.ControlsOn)
        {
            transform.position = GetMouseWorldPosition() + mousePositionOffset;
            KeepInBounds();
            if (inkCoolDownTimer == 0)
            {
                ShootInk();
                inkCoolDownTimer = inkCoolDownTimerMax;
            }
        }
    }

    public void ShootInk()
    {
        if (Globals.CurrentGameState == Globals.GameState.Playing)
        {
            bulletType = bulletType == 0 ? 1 : 0;
            audioManager.PlayShootSound();
            GameObject BulletPrefab = InkBulletPrefab;
            if (Globals.CurrentPlayerType == Globals.PlayerTypes.Santa)
                BulletPrefab = PresentBulletPrefab;
            else if (Globals.CurrentPlayerType == Globals.PlayerTypes.Zombie)
                BulletPrefab = SlimeBulletPrefab;
            else if (Globals.CurrentPlayerType == Globals.PlayerTypes.Johnny)
                BulletPrefab = NoteBulletPrefab;
            else if (Globals.CurrentPlayerType == Globals.PlayerTypes.Bo)
                BulletPrefab = BasketballBulletPrefab;
            else if (Globals.CurrentPlayerType == Globals.PlayerTypes.Violet)
                BulletPrefab = VioletBulletPrefab;
            else if (Globals.CurrentPlayerType == Globals.PlayerTypes.Matt)
                BulletPrefab = bulletType == 0 ? MattBulletPrefab : MattBullet2Prefab;
            GameObject bulletGameObject = (GameObject)Instantiate(BulletPrefab, Muzzle.transform.position, Quaternion.identity, BulletContainer.transform);
            bulletGameObject.GetComponent<Rigidbody2D>().velocity = bulletMovementVector;

            if (superInkTimer > 0)
            {
                GameObject bulletGameObject2 = (GameObject)Instantiate(BulletPrefab, Muzzle.transform.position, Quaternion.identity, BulletContainer.transform);
                bulletGameObject2.GetComponent<Rigidbody2D>().velocity = new Vector2(10f, 4f);
                GameObject bulletGameObject3 = (GameObject)Instantiate(BulletPrefab, Muzzle.transform.position, Quaternion.identity, BulletContainer.transform);
                bulletGameObject3.GetComponent<Rigidbody2D>().velocity = new Vector2(10f, -4f);
            }
        }
    }

    public void MoveUpButtonDown()
    {
        moveUpButton = true;
    }
    public void MoveLeftButtonDown()
    {
        moveLeftButton = true;
    }
    public void MoveDownButtonDown()
    {
        moveDownButton = true;
    }
    public void MoveRightButtonDown()
    {
        moveRightButton = true;
    }
    public void ShootInkButtonDown()
    {
        shootInkButton = true;
        ShootInk();
    }
    public void MoveUpButtonUp()
    {
        moveUpButton = false;
    }
    public void MoveLeftButtonUp()
    {
        moveLeftButton = false;
    }
    public void MoveDownButtonUp()
    {
        moveDownButton = false;
    }
    public void MoveRightButtonUp()
    {
        moveRightButton = false;
    }
    public void ShootInkButtonUp()
    {
        shootInkButton = false;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Bullet bullet = collider.gameObject.GetComponent<Bullet>();
        Enemy enemy = collider.gameObject.GetComponent<Enemy>();
        if (bullet != null && bullet.GetComponent<Bullet>().enemyBullet && Globals.CurrentGameState == Globals.GameState.Playing)
        {
            if (IsInvincible())
            {
                audioManager.PlayEnemyZappedSound();
            }
            else if (IsHitInvincible())
            {

            }
            else
            {
                sceneManager.EnemyHit();
            }

            Destroy(collider.gameObject);
        }
        else if (enemy != null && Globals.CurrentGameState == Globals.GameState.Playing)
        {
            if (IsInvincible())
            {
                enemy.KillEnemy(collider);
            }
            else if (IsHitInvincible())
            {

            }
            else
            {
                sceneManager.EnemyHit();
            }
        }
    }
}
