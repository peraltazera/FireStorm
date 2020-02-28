using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Char
{
    public float _damage;
    public float _fieldOsView;
    public float _fieldOfSong;

    public virtual void Attack()
    { 
        print("Attack"); 
    } 
}
