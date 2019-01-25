using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveWater : MonoBehaviour
{
    BoxCollider2D col2d;

    void Start()
    {
        col2d = GetComponent<BoxCollider2D>();
    }

    public bool Check(int numLiquid)
    {
        int count = 0;
        var cols = new Collider2D[Mathf.Max(10, numLiquid)];
        int num = Physics2D.OverlapCollider(col2d, new ContactFilter2D(), cols);
        foreach (var col in cols)
        {
            if (col!=null && col.gameObject.tag == "Liquid")
            {
                count++;
                if (count >= numLiquid)
                    return true;
            }
        }
        return false;
    }

    public int RemoveLiquid(int numLiquid)
    {
        int count = 0;
        var cols = new Collider2D[numLiquid];
        int num = Physics2D.OverlapCollider(col2d, new ContactFilter2D(), cols);
        foreach (var col in cols)
        {
            if (col!=null && col.gameObject.tag == "Liquid")
            {
                count++;
                Destroy(col.gameObject);
                if (count >= numLiquid)
                    return count;
            }
        }
        return count;
    }
}
