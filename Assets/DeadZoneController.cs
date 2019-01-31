using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZoneController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Liquid")
        {
            Destroy(collision.gameObject);
        }
        if (collision.tag == "Player")
        {
            collision.GetComponent<PlayerController>().m_Anim.Play("Die");
        }
    }
}
