using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : Char
{   
    [Header("Components")]
    [Header("Player")]
    public Rigidbody rigid;
    [Header("Equips")]
    public List<Equip> equip;
    public int equipIndex;

    public virtual void Start()
    { 
        base.Start();
        rigid = GetComponent<Rigidbody>();
    } 

    void Update()
    {
        //Mov();
        //Damage();
        //_equip[_equipIndex].Action(_anim);
    }

    public override void Mov()
    {
        float _movX = Input.GetAxis("Horizontal");
        float _movZ = Input.GetAxis("Vertical");
        rigid.velocity = new Vector3(_movX * speed, rigid.velocity.y, _movZ * speed);
    }
}
