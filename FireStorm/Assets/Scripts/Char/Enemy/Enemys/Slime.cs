using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Enemy
{
    void Update()
    {
        Mov();
        Attack();
        Damage();
    }

    public override void Mov()
    {
        print("MovSlime");
    }

    public override void Attack()
    {
        print("AttackSlime");
    }
}
