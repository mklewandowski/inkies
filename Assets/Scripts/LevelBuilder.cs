using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBuilder
{
    public static void BuildLevels(List<EnemyWave> waves)
    {
        // LEVEL 1, 10 WAVES
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,

            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,

            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,

            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,

            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,

            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,

            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.FishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishMiddle,
            Enemy.EnemyType.None, Enemy.EnemyType.FishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishMiddle,
            Enemy.EnemyType.None, Enemy.EnemyType.FishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishMiddle,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.FishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishMiddle,
            Enemy.EnemyType.None, Enemy.EnemyType.FishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishMiddle,
            Enemy.EnemyType.None, Enemy.EnemyType.FishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishMiddle,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.FishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.FishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.FishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp, Enemy.EnemyType.Mollusk,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.FishUp, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.FishUp, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.FishUp, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.FishUp, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.FishUp, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.FishUp, Enemy.EnemyType.Mollusk,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.FishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.FishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.FishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishMiddle, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishMiddle, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
        }));


        // LEVEL 2, 10 WAVES
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,

            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,

            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,

            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,

            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,

            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,

            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Fish,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.Fish, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishUp,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishMiddle,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishMiddle,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishMiddle,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishMiddle,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishMiddle,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishMiddle,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishUp,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.Diver, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.Mollusk,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishMiddle,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishMiddle,
        }));

        // LEVEL 3, 10 WAVES
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.Diver, Enemy.EnemyType.FishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishMiddle, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.FishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishMiddle, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.FishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishMiddle, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.FishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishMiddle, Enemy.EnemyType.Mollusk,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishMiddle, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishMiddle, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishMiddle, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishMiddle, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishMiddle, Enemy.EnemyType.Mollusk,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishUp, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishUp, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishUp, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishUp, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishUp, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishUp, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishUp, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishUp, Enemy.EnemyType.Mollusk,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.None, Enemy.EnemyType.FishDown, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.FishUp,
            Enemy.EnemyType.Diver, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
        }));

        // LEVEL 4, 10 WAVES
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
            Enemy.EnemyType.Diver, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
            Enemy.EnemyType.Diver, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
            Enemy.EnemyType.Diver, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunFish,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishBounce,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishBounce, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishBounce, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFishBounce, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.FishBounce,
            Enemy.EnemyType.None, Enemy.EnemyType.FishBounce, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
        }));
    }
}
