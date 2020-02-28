using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Char
{   
    public List<Equip> _equip;
    public int _equipIndex;

    void Update()
    {
        Mov();
        Damage();
        _equip[_equipIndex].Action(_anim);
    }

    public override void Mov()
    {
        float _movX = Input.GetAxis("Horizontal");
        float _movZ = Input.GetAxis("Vertical");
        _rigid.velocity = new Vector3(_movX * _speed, _rigid.velocity.y, _movZ * _speed);
        print("MovPlayer");
    }
}
