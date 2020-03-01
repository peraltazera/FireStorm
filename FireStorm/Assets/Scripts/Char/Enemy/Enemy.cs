using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(FieldOfView))]
public class Enemy : Char
{
    [Header("Components")]
    [Header("Enemy")]
    public NavMeshAgent agent;
    public FieldOfView fieldOsView;
    public FieldOfView fieldOfSong;
    [Header("Stats")]
    public float distAttack;
    public float damage;
    public bool perception;

    public override void Start()
    { 
        base.Start();
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
        agent.stoppingDistance = distAttack;
        fieldOsView = GetComponent<FieldOfView>();
        fieldOsView.enemy = GetComponent<Enemy>();
    } 

    public virtual void Update()
    {
        Perception(perception = (fieldOsView.visibleTargets.Count > 0) ? true : false);
    }

    public virtual void Attack()
    { 
        print("Attack" + name + ": " + damage); 
    } 

    public virtual void Perception(bool _perception)
    {
        if(_perception)
            agent.SetDestination(fieldOsView.visibleTargets[0].position);
        else
            agent.SetDestination(this.gameObject.transform.position);
        print("Perception"  + name + ": " + _perception); 
    }
}
