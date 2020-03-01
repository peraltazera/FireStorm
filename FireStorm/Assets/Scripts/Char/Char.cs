using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(BoxCollider))]
public class Char : MonoBehaviour
{
    [Header("Components")]
    [Header("Char")]
    public Animator anim;
    public BoxCollider boxCollider;
    [Header("Stats")]
    public string name;
    public float life;
    public float speed;

    public virtual void Start()
    {
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider>();
    }

    public virtual void Mov()
    { 
        print("Mov" + name + ": " + speed); 
    } 

    public void Damage(int _damage)
    { 
        life -= _damage;
        print("Damage" + name + ": " + _damage);
    } 
}
