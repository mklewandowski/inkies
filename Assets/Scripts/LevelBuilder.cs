using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBuilder
{
    public static void BuildLevels(List<EnemyWave> waves)
    {
        // LEVEL 1, 10 WAVES
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None,
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk
        }));


        // LEVEL 2, 10 WAVES
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.Diver, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.Diver, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.None, Enemy.EnemyType.GunMollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.GunFish, Enemy.EnemyType.Mollusk
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk
        }));
        waves.Add(new EnemyWave(new Enemy.EnemyType[]{
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk,
            Enemy.EnemyType.None, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Fish, Enemy.EnemyType.Mollusk
        }));
    }
}
