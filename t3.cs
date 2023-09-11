using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t3 : MonoBehaviour
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
        p.speed = 3.0f;
    }
}
