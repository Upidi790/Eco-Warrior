using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceManager1 : MonoBehaviour
{
    public static ExperienceManager1 Instance;

    public delegate void ExperienceChangeHandler1(int amount);
    public event ExperienceChangeHandler1 OnExperienceChange;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void AddExperience1(int amount)
    {
        OnExperienceChange?.Invoke(amount);
    }
}
