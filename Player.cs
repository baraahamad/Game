using UnityEngine;

public class Player : Character
{

    public Player(string name, int health) : base(name, health) { }


    public void Heal(int amount)
    {
        Health += amount;
        Debug.Log($"{Name} healed by {amount}. New health: {Health}");
    }
}

