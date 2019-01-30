using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquidGenarate : MonoBehaviour
{
    public int _numLiquid = 10;
    public float _size = 1;
    public GameObject _prefab;
    public GameObject _pool;

    // Use this for initialization
    void Start()
    {
        var col = GetComponent<BoxCollider2D>();
        GenerateLiquid(_numLiquid, col.bounds);
    }

    public void GenerateLiquid(int numLiquid, Bounds bounds)
    {
        for (int i = 0; i < numLiquid; i++)
        {
            GenerateLiquidOne(new Vector2(
                Random.Range(bounds.min.x, bounds.max.x),
                Random.Range(bounds.min.y, bounds.max.y)
            ));
        }
    }

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
