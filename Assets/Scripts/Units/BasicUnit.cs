using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public  abstract class BasicUnit : MonoBehaviour,IDamageable
{
    public NavMeshAgent navMeshAgent;
    public enum UnitType{
        Trooper,
        Sniper,
        Medic,
        Oficer,
        Reporter
    }
    public string Name;
    public float Fear;
    public int Health;
    public int AtackRange;
    public int Damage;
    public int Delay;
    public bool IsSelected = false;
    public bool InBuilding;
    public bool IsAlive = true;
    public UnitType unitType;

    private int MaxHealth;

    public virtual void MoveTo(Vector3 point){
        navMeshAgent.SetDestination(point);
    }
    
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
       if(IsSelected){
        if(Input.GetMouseButton(1)){
            
        }
       } 
    }

    public void TakeDamage(int damage)
    {
        this.Health -= damage;
        if(this.Health <= 0){
            this.Health = 0;
            IsAlive = false;
        }
    }

    public void TakeHeal(int points)
    {
        this.Health += points;
        if(this.Health > MaxHealth){
            this.Health = MaxHealth;
        }
    }
}
