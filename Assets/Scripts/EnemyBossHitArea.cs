using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBossHitArea : MonoBehaviour
{
    [SerializeField]
    EnemyBoss enemyBoss;

    [SerializeField]
    bool isHead = false;

    void OnTriggerEnter2D(Collider2D collider)
    {
        Bullet bullet = collider.gameObject.GetComponent<Bullet>();
        if (bullet != null && !bullet.GetComponent<Bullet>().enemyBullet && Globals.CurrentGameState == Globals.GameState.Playing)
        {
            if (isHead)
                enemyBoss.HitHead();
            else
                enemyBoss.HitBody();

            Destroy(collider.gameObject);
        }
    }
}
