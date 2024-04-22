using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    int currentHealth, maxHealth,
        currentExperience, maxExperience,
        currentLevel;

    private void OnEnable()
    {
        ExperienceManager1.Instance.OnExperienceChange += HandleExperienceChange;
    }

    private void OnDisable()
    {
        ExperienceManager1.Instance.OnExperienceChange -= HandleExperienceChange;
    }

    private void HandleExperienceChange(int newExperience)
    {
        currentExperience += newExperience;
        if(currentExperience >= maxExperience)
        {
            LevelUp();
        }

    }

    private void LevelUp()
    {
        maxHealth += 10;
        currentHealth = maxHealth;

        currentLevel++;

        currentExperience = 0;
        maxExperience += 100;
    }
}
