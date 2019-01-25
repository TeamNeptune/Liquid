﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceWater : MonoBehaviour
{
    public float _size = 1;
    public GameObject _prefab;
    public GameObject _pool;

    BoxCollider2D col2d;
    Bounds bounds;

    void Start()
    {
        col2d = GetComponent<BoxCollider2D>();
        bounds = col2d.bounds;
    }

    public bool Check()
    {
        var cols = new Collider2D[10];
        int num = Physics2D.OverlapCollider(col2d, new ContactFilter2D(), cols);
        foreach (var col in cols)
        {
            if (col != null && col.gameObject.tag == "Ground" && col.gameObject.tag == "Block")
            {
                return false;
            }
        }
        return true;
    }

    public void GenerateLiquid(int numLiquid)
    {
        float sqrt = Mathf.Max(1, Mathf.Sqrt(numLiquid));
        for (int i = 0; i < numLiquid; i++)
        {
            GameObject temp = Instantiate(_prefab, transform) as GameObject;
            float x = Mathf.Lerp(bounds.min.x, bounds.max.x, (i % (int)sqrt) / sqrt);
            float y = Mathf.Lerp(bounds.min.y, bounds.max.y, (i / (int)sqrt) / sqrt);
            temp.transform.localScale *= _size;
            temp.transform.localPosition = new Vector3(x, -y, 0);
            temp.transform.parent = _pool.transform;
        }
    }
}
