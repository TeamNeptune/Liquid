using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquidContent : MonoBehaviour
{
    public float _size = 1;
    public GameObject _prefab;
    public GameObject _pool;

    public void GenerateLiquidOne(Vector2 pos)
    {
        GameObject temp = Instantiate(_prefab, _pool.transform) as GameObject;
        temp.transform.localPosition = pos;
        temp.transform.localScale *= _size;
    }

    public void GenerateLiquidOne(Vector2 pos, Vector2 vel)
    {
        GameObject temp = Instantiate(_prefab, _pool.transform) as GameObject;
        temp.transform.localPosition = pos;
        temp.transform.localScale *= _size;
        temp.transform.GetComponent<Rigidbody2D>().velocity = vel;
    }
}
