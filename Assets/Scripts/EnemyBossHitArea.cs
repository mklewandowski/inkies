using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBossHitArea : MonoBehaviour
{
    [SerializeField]
    EnemyBoss EnemyBoss;

    [SerializeField]
    bool IsHead = false;

    void OnTriggerEnter2D(Collider2D collider)
    {
        Bullet bullet = collider.gameObject.GetComponent<Bullet>();
        if (bullet != null && !bullet.GetComponent<Bullet>().enemyBullet && Globals.CurrentGameState == Globals.GameState.Playing)
        {
            if (IsHead)
                EnemyBoss.HitHead();
            else
                EnemyBoss.HitBody();

            Destroy(collider.gameObject);
        }
    }
}
