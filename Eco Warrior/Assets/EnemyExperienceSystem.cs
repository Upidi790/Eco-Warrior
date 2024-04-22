using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public enum EnemyType
    {
        Small,
        Big,
        Boss
    }

    public EnemyType enemyType;
    public int smallMobXP = 5;
    public int bigMobXP = 20;
    public int bossXP = 100;

    void OnDestroy()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            ExperienceSystem playerExperience = player.GetComponent<ExperienceSystem>();
            if (playerExperience != null)
            {
                switch (enemyType)
                {
                    case EnemyType.Small:
                        playerExperience.GainExperience(smallMobXP);
                        break;
                    case EnemyType.Big:
                        playerExperience.GainExperience(bigMobXP);
                        break;
                    case EnemyType.Boss:
                        playerExperience.GainExperience(bossXP);
                        break;
                }
            }
        }
    }
}
