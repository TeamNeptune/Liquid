using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquidGenarate : MonoBehaviour
{
    public int _numLiquid = 10;
    LiquidContent content;

    // Use this for initialization
    void Start()
    {
        var col = GetComponent<BoxCollider2D>();
        content = GameObject.Find("LiquidContent").GetComponent<LiquidContent>();
        GenerateLiquid(_numLiquid, col.bounds);
    }

    public void GenerateLiquid(int numLiquid, Bounds bounds)
    {
        for (int i = 0; i < numLiquid; i++)
        {
            content.GenerateLiquidOne(new Vector2(
                Random.Range(bounds.min.x, bounds.max.x),
                Random.Range(bounds.min.y, bounds.max.y)
            ));
        }
    }
}
