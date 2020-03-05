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

    public bool teste;
    
    public Transform player;
    public Vector3 oldPosition;

    public override void Start()
    { 
        base.Start();
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
        agent.stoppingDistance = distAttack;
        fieldOsView = GetComponent<FieldOfView>();
        fieldOsView.enemy = GetComponent<Enemy>();
        oldPosition = transform.position;
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
        {
            agent.SetDestination(fieldOsView.visibleTargets[0].position);
            float dist = Vector3.Distance(fieldOsView.visibleTargets[0].position, transform.position);
            if(dist <= distAttack)
            {
                if(oldPosition == transform.position)
                {
                    anim.SetBool("stay", false);
                    anim.SetBool("walk", false);
                    anim.SetBool("attack", true);
                }
                else
                {
                    anim.SetBool("stay", false);
                    anim.SetBool("walk", true);
                    anim.SetBool("attack", false);
                }
            }
            else
            {
                anim.SetBool("stay", false);
                anim.SetBool("walk", true);
                anim.SetBool("attack", false);
            }
        }
        else
        {
            agent.SetDestination(this.gameObject.transform.position);
            anim.SetBool("walk", false);
            anim.SetBool("stay", true);
            anim.SetBool("attack", false);
        }
        oldPosition = transform.position;
        print("Perception"  + name + ": " + _perception); 
    }
}
