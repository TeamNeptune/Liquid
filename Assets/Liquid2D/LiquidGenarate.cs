using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquidGenarate : MonoBehaviour {
    public int _numLiquid = 10;
    public float _size = 1;
    public GameObject _prefab;
	
	// Use this for initialization
	void Start () {
        var col = GetComponent<BoxCollider2D>();
		for (int i = 0; i < _numLiquid; i++) {
			GameObject temp = Instantiate(_prefab) as GameObject;
			float x = Random.Range(col.bounds.min.x, col.bounds.max.x);
			float y = Random.Range(col.bounds.min.y, col.bounds.max.y);
			temp.transform.localPosition = new Vector3 (x, y, 0);
            temp.transform.localScale *= _size;
			temp.transform.parent = transform;
		}
	}
}
