using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NPC
{
    public string Name { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public int InteractionRadius { get; set; }

    public NPC(string name, int x, int y, int interactionRadius)
    {
        Name = name;
        X = x;
        Y = y;
        InteractionRadius = interactionRadius;
    }

    public void Interact()
    {
        Console.WriteLine($"You interacted with {Name}.");
        Console.WriteLine($"Hello! I'm {Name}. How can I help you?");
    }

    public bool IsPlayerWithinRange(int playerX, int playerY)
    {
        int distanceSquared = (playerX - X) * (playerX - X) + (playerY - Y) * (playerY - Y);
        int radiusSquared = InteractionRadius * InteractionRadius;
        return distanceSquared <= radiusSquared;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of NPC
        NPC npc = new NPC("Bob", 5, 5, 3); // NPC located at (5, 5) with a radius of 3

        // Simulate player movement
        int playerX = 4;
        int playerY = 4;

        // Check if the player is within range
        if (npc.IsPlayerWithinRange(playerX, playerY))
        {
            // Interact with the NPC
            npc.Interact();
        }
        else
        {
            Console.WriteLine("No NPC within interaction range.");
        }
    }
}
