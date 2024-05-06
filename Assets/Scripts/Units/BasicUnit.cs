using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public  abstract class BasicUnit : MonoBehaviour
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

    public UnitType unitType;

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
}
