using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TreeController : MonoBehaviour
{
    public List<Sprite> treeSprites = new List<Sprite>();
    public int grows = 0;
    public int amount = 0;
    public int amountMax = 100;
    SpriteRenderer render;

    void Start()
    {
        render = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (grows >= treeSprites.Count - 1)
        {
            SceneManager.LoadScene("GameClearResultScene");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Liquid")
        {
            Destroy(collision.gameObject);
            amount++;

            if (amount >= amountMax)
            {
                grows++;
                amount -= amountMax;
            }

            grows = Mathf.Min(grows, treeSprites.Count - 1);

            render.sprite = treeSprites[grows];
        }
    }
}
