using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char : MonoBehaviour
{
    public Rigidbody _rigid;
    public Animator _anim;
    public BoxCollider _boxCollider;
    public string _name;
    public float _life;
    public float _speed;

    void Start()
    {
        _rigid = GetComponent<Rigidbody>();
        _anim = GetComponent<Animator>();
        _boxCollider = GetComponent<BoxCollider>();
    }

    public virtual void Mov()
    { 
        print("Mov"); 
    } 

    public void Damage()
    { 
        print("Damage"); 
    } 
}
