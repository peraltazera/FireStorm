using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Enemy
{
    //[Header("Slime")]

    public override void Update()
    {
        base.Update();
        // Mov();
        // Attack();
        // Damage();
        // Perception();
    }

    public override void Mov()
    { 
        base.Mov(); 
    }

    public override void Attack()
    { 
        base.Attack(); 
    }

    public override void Perception(bool _perception)
    { 
        base.Perception(_perception); 
    }
}
