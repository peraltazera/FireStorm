using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equip : MonoBehaviour
{
    public string _name;

    public virtual void Action(Animator anim)
    { 
        print("Action"); 
    } 
}
