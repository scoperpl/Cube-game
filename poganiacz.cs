using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class poganiacz : MonoBehaviour
{
    public float speed = 2f;
    private float y2;
    private float x;
    GameObject go1;
    // Start is called before the first frame update
    void Start()
    {
        GameObject go = GameObject.Find("mySprite");
        go1 = go;

    }
    
    // Update is called once per frame
    void Update()
    {
        x = GameObject.Find("mySprite").transform.position.x;
        TMP_Text text = GameObject.Find("0").GetComponent<TMP_Text>();
        y2 = int.Parse(text.text);
        if (y2 < 20)
        {
            transform.position = new Vector3(0, -20, 0);
        }
        else if(y2 > 20 && y2 < 30)
        {
            transform.position = new Vector3(0, 10, 0);
        }
        
        else if(y2 > 30 && y2 < 500)
        {
            transform.position = Vector3.MoveTowards(transform.position, go1.transform.position, speed*0.05f);
        }
        else if (y2 > 20 && y2 < 30 && x == 0.23f)
        {
            transform.position = new Vector3(158.23f, 10, 0);
        }
        else if(x == 0.23f && y2>30)
        {
            transform.position = Vector3.MoveTowards(transform.position, go1.transform.position, speed * 0.05f);
        }

    }
}
