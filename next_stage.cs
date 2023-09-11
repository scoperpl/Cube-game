using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class next_stage : MonoBehaviour
{
    GameObject go;
    GameObject button1;
    // Start is called before the first frame update
    void Start()
    {
        GameObject button = GameObject.Find("portal_button");
        button1 = button;
        button1.gameObject.SetActive(false);        
    }

    // Update is called once per frame
    void Update()
    {
        TMP_Text text1;
        text1 = GameObject.Find("0").GetComponent<TMP_Text>();
        if (int.Parse(text1.text) > 500)
        {
            GameObject.Find("mySprite").GetComponent<player>().enabled=false;
            button1.SetActive(true);
        }
    }
    public void next_stage1()
    {
        TMP_Text text1;
        text1 = GameObject.Find("0").GetComponent<TMP_Text>();
        text1.text = "0";
        go = GameObject.Find("mySprite");
        go.transform.position= new Vector3(158.23f, 0.23f, 0);
        button1.SetActive(false);
        go.GetComponent<player>().enabled=true;
    }
}
