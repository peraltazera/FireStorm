using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
