using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Liquid")
            Destroy(gameObject);
        else if (collision.tag == "Player")
        {
            collision.GetComponent<PlayerController>().m_Anim.Play("Die");
        }
    }
}
