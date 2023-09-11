using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class teleport : MonoBehaviour
{
    public Texture2D texture;
    private Sprite mySprite2;
    private SpriteRenderer myRenderer2;
    private Collider2D myCollider2 = new Collider2D();
    
    void Awake()
    {
        myRenderer2 = gameObject.AddComponent<SpriteRenderer>() as SpriteRenderer;
        myRenderer2.color = new Color(0.9f, 0.9f, 0.9f, 1.0f);
    }
    // Start is called before the first frame update
    void Start()
    {
    mySprite2 = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject mysprite = GameObject.Find("mySprite");
        TMP_Text textMeshPro = GameObject.Find("0").GetComponent<TMP_Text>();
        int x = int.Parse(textMeshPro.text);
        if (Input.GetKeyUp("space") && x >= 300f && x <= 500f)
        {
            float y = mysprite.transform.position.y;
            transform.position = new Vector3(0, y + 10, 5);
            myRenderer2.sprite = mySprite2;
            transform.localScale = new Vector3((y-300)*0.05f,(y-300)*0.05f,(1));
        }
        else if (Input.GetKeyUp("space") & x >= 500)
        {
            float y = mysprite.transform.position.y;
            transform.localScale = new Vector3((y - 300) * 0.05f, (y - 300) * 0.05f, (1));
            transform.position = new Vector3(0f, y, 0.0f);
            Debug.Log(mysprite.transform.position.y.ToString());
        }
    }
}
