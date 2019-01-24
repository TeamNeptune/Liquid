using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquidGenarate : MonoBehaviour {
    public int _numLiquid = 10;
    public float _size = 1;
    public GameObject _prefab;
    public GameObject _pool;

    // Use this for initialization
    void Start () {
        var col = GetComponent<BoxCollider2D>();
        GenerateLiquid(_numLiquid, col.bounds);
	}

    public void GenerateLiquid(int numLiquid, Bounds bounds)
    {
        for (int i = 0; i < numLiquid; i++)
        {
            GameObject temp = Instantiate(_prefab, _pool.transform) as GameObject;
            float x = Random.Range(bounds.min.x, bounds.max.x);
            float y = Random.Range(bounds.min.y, bounds.max.y);
            temp.transform.localPosition = new Vector3(x, y, 0);
            temp.transform.localScale *= _size;
        }
    }
}
