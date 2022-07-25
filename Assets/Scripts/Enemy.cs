using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    AudioManager audioManager;
    SceneManager sceneManager;

     bool isActive = true;

    public enum EnemyType {
        Fish,
        Diver,
        Mollusk,
        GunMollusk
    }
    public EnemyType enemyType = EnemyType.Fish;

    void Awake()
    {
        audioManager = GameObject.Find("SceneManager").GetComponent<AudioManager>();
        sceneManager = GameObject.Find("SceneManager").GetComponent<SceneManager>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Player player = collider.gameObject.GetComponent<Player>();
        InkBullet bullet = collider.gameObject.GetComponent<InkBullet>();
        if (player != null && Globals.CurrentGameState == Globals.GameState.Playing && isActive)
        {
            isActive = false;

            // kill player
        }
        else if (bullet != null && Globals.CurrentGameState == Globals.GameState.Playing && isActive)
        {
            audioManager.PlayEnemyZappedSound();

            isActive = false;

            Destroy(this.gameObject);
            Destroy(collider.gameObject);
        }
    }

}
