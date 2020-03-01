using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equip : MonoBehaviour
{
    [Header("Equip")]
    public string name;

    public virtual void Action(Animator anim)
    { 
        print("Action" + name); 
    } 
}
