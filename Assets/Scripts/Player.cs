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

    Vector2 projectileMovementVector = new Vector2(10f, 0);
    Vector2 movementVector = new Vector2(0, 0);
    float minX = -5f;
    float maxX = 5f;
    float minY = -5f;
    float maxY = 5f;
    bool moveLeft;
    bool moveRight;
    bool moveUp;
    bool moveDown;
    float moveSpeed = 6f;

    void Awake()
    {
        audioManager = GameObject.Find("SceneManager").GetComponent<AudioManager>();
        sceneManager = GameObject.Find("SceneManager").GetComponent<SceneManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Globals.CurrentGameState == Globals.GameState.Playing)
        {
            moveLeft = Input.GetKey(KeyCode.LeftArrow);
            moveRight = Input.GetKey(KeyCode.RightArrow);
            moveUp = Input.GetKey(KeyCode.UpArrow);
            moveDown = Input.GetKey(KeyCode.DownArrow);
            movementVector = new Vector2(0, 0);
            if (moveLeft)
                movementVector.x = moveSpeed * -1f;
            else if (moveRight)
                movementVector.x = moveSpeed;
            if (moveUp)
                movementVector.y = moveSpeed;
            else if (moveDown)
                movementVector.y = moveSpeed * -1f;
            GetComponent<Rigidbody2D>().velocity = movementVector;

            if (Input.GetKeyDown(KeyCode.Space))
                ShootInk();

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
    }

    void ShootInk()
    {
        audioManager.PlayShootSound();
        GameObject projectileGameObject = (GameObject)Instantiate(InkBulletPrefab, Muzzle.transform.position, Quaternion.identity, BulletContainer.transform);
        projectileGameObject.GetComponent<Rigidbody2D>().velocity = projectileMovementVector;
    }
}
