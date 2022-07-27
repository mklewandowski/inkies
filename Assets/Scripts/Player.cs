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
    GameObject Muzzle;

    [SerializeField]
    GameObject BulletContainer;

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
    float moveSpeed = 6f;

    Vector3 mousePositionOffset;

    Vector3 touchPosition;
    Vector3 direction;
    private Rigidbody2D playerRigidbody;

    float inkCoolDownTimer = 0f;
    float inkCoolDownTimerMax = .25f;

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
        Enemy[] enemies = GameObject.FindObjectsOfType<Enemy>(true);
        for (int i = 0; i < enemies.Length; i++)
        {
            Destroy(enemies[i].gameObject);
        }

        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        this.transform.localPosition = initialPos;
        this.GetComponent<Collider2D>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Globals.CurrentGameState == Globals.GameState.Playing)
        {
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
            playerRigidbody.velocity = movementVector;

            if (inkCoolDownTimer > 0)
            {
                inkCoolDownTimer -= Time.deltaTime;
                if (inkCoolDownTimer <= 0)
                    inkCoolDownTimer = 0;
            }

            if (Input.touchCount > 0)
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
        mousePositionOffset = gameObject.transform.position - GetMouseWorldPosition();
        ShootInk();
        inkCoolDownTimer = inkCoolDownTimerMax;
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPosition() + mousePositionOffset;
        KeepInBounds();
        if (inkCoolDownTimer == 0)
        {
            ShootInk();
            inkCoolDownTimer = inkCoolDownTimerMax;
        }
    }

    public void ShootInk()
    {
        if (Globals.CurrentGameState == Globals.GameState.Playing)
        {
            audioManager.PlayShootSound();
            GameObject bulletGameObject = (GameObject)Instantiate(InkBulletPrefab, Muzzle.transform.position, Quaternion.identity, BulletContainer.transform);
            bulletGameObject.GetComponent<Rigidbody2D>().velocity = bulletMovementVector;
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

    void OnTriggerEnter2D(Collider2D collider)
    {
        Bullet bullet = collider.gameObject.GetComponent<Bullet>();
        Enemy enemy = collider.gameObject.GetComponent<Enemy>();
        if (bullet != null && bullet.GetComponent<Bullet>().enemyBullet && Globals.CurrentGameState == Globals.GameState.Playing)
        {
            audioManager.PlayGameOver();

            Destroy(collider.gameObject);

            this.GetComponent<Collider2D>().enabled = false;

            sceneManager.GameOver();
        }
        else if (enemy != null && Globals.CurrentGameState == Globals.GameState.Playing)
        {
            audioManager.PlayGameOver();

            this.GetComponent<Collider2D>().enabled = false;

            sceneManager.GameOver();
        }
    }
}
