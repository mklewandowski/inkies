using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWave
{
    public Enemy.EnemyType[] Enemies;

    public EnemyWave(Enemy.EnemyType[] enemies)
    {
        Enemies = new Enemy.EnemyType[enemies.Length];
        for (int x = 0; x < enemies.Length; x++)
        {
            Enemies[x] = enemies[x];
        }
    }

}
