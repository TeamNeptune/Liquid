using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManjiRotate : MonoBehaviour
{
    public float speed = 5;
    
    void Update()
    {
        Rigidbody2D rigid = GetComponent<Rigidbody2D>();
        rigid.AddTorque(speed * Time.deltaTime);
    }
}
