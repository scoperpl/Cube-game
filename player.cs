using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        koniec();
        if (Input.GetKeyUp("space"))
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.MovePosition(rb.position + new Vector2(0f, 75f) * Time.fixedDeltaTime);   
        }
      else if (Input.GetKeyUp("c"))
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.MovePosition(rb.position + new Vector2(0f, -75f) * Time.fixedDeltaTime);
            TMP_Text text1;
            text1 = GameObject.Find("0").GetComponent<TMP_Text>();
        }
    }
    private SpriteRenderer sr;
    private Rigidbody2D R2D;
    public void koniec()
    {
        SpriteRenderer spriteRenderer = GameObject.Find("mySprite").GetComponent<SpriteRenderer>();
        TMP_Text text1;
        text1 = GameObject.Find("0").GetComponent<TMP_Text>();
        int text1i = 1;
        float y = transform.position.y;
        text1i = (int)Mathf.Ceil(y);
        text1.text = text1i.ToString();
        int text_value;
        text_value = int.Parse(text1.text);
        if (text_value >= 100)
        {
            spriteRenderer.color = Color.green;
        }
        else if (text_value >= (300))
        {
        spriteRenderer.color= Color.blue;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.GetType() == typeof(PolygonCollider2D))
        {
            Destroy(collision.gameObject);
            Debug.Log("kolizja");
        }
        else
        {
            TMP_Text text1;
            text1 = GameObject.Find("0").GetComponent<TMP_Text>();
            int text1i = 0;
            text1.text = text1i.ToString();
            Rigidbody2D rigidbody2D = GameObject.Find("mySprite").GetComponent<Rigidbody2D>();
            transform.rotation = Quaternion.identity;
            transform.position = new Vector3(-0.027F, 0.21F, 0);
        }
    }
}
