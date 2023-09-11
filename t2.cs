using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class t2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void trudnosc()
    {
        GameObject go = GameObject.Find("mySprite3");
        poganiacz p;
        p = go.GetComponent<poganiacz>();
        p.speed = 2.0f;
    }
}
