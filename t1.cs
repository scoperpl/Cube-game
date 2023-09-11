using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class t1 : MonoBehaviour
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
        p.speed = 1.0f;
        Button guziczek = GameObject.Find("Button").GetComponent<Button>();
        guziczekc.normalColor = new Vector4(178, 228, 237, 255);
        guziczek.GetComponent<Button>().colors = guziczekc;
    }
}
