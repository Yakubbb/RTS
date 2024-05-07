using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicBuilding : IDamageable
{
    public int Capacity;
    public bool IsDestroyed = false;
    private int MaxHealth;
    public int Health;
    public bool IsSelected;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        Health-=damage;
        if(Health <= 0){
            Health=0;
            IsDestroyed = true;
        }
    }

    public void TakeHeal(int points)
    {
        Health+=points;
        if(Health > MaxHealth){
            Health = MaxHealth;
        }
    }
}
