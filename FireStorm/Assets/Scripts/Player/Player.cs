using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rigid;
    public float speed;
    
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float movX = Input.GetAxis("Horizontal");
        float movZ = Input.GetAxis("Vertical");
        rigid.velocity = new Vector3(movX * speed, rigid.velocity.y, movZ * speed);
    }
}
