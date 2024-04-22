using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceManager1 : MonoBehaviour
{
    public static ExperienceManager1 Instance; // creation of ExperienceManager

    public delegate void ExperienceChangeHandler1(int amount); // determines the amount of XP that will be added to the XP bar
    public event ExperienceChangeHandler1 OnExperienceChange; // trigger event of XP change


    private void Awake() // activation of ExperienceManager and its processes, based on conditionals in the ifelse statement
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

    public void AddExperience1(int amount) // adds experience to the player's XP bar
    {
        OnExperienceChange?.Invoke(amount);
    }
}
