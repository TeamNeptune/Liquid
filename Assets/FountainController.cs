using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FountainController : MonoBehaviour
{
    LiquidContent generator;
    public Vector3 velocity = Vector3.up * 10;

    // Start is called before the first frame update
    void Start()
    {
        generator = GameObject.Find("LiquidContent").GetComponent<LiquidContent>();
    }

    // Update is called once per frame
    void Update()
    {
        generator.GenerateLiquidOne(
            transform.position,
            Matrix4x4.Rotate(
                Quaternion.AngleAxis(Random.Range(-30, 30), Vector3.forward))
                .MultiplyVector(velocity)
            );
    }
}
