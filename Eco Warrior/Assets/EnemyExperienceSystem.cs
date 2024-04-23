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

    [SerializeField] int experienceValue;

    private void OnDestroy()
    {
        // When the enemy is destroyed, add its experience value to the player's XP
        ExperienceManager1.Instance.AddExperience1(experienceValue);
    }
}

public class EnemyTypeSmall : Enemy
{
    // Customize specific behavior or properties for Enemy Type 1 if needed
}

public class EnemyTypeBig : Enemy
{
    // Customize specific behavior or properties for Enemy Type 2 if needed
}

public class EnemyTypeBoss : Enemy
{
    // Customize specific behavior or properties for Enemy Type 3 if needed
}
