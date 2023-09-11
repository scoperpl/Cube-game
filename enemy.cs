using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class enemy : MonoBehaviour
{
    public float movement_speed = 3f;
    private float horizontalinputf;
    private float y;

    // Start is called before the first frame update
    void Start()
    {
        float horizontalInput = transform.position.x/3.5f;
        horizontalinputf = horizontalInput;
        GameObject go = GameObject.Find("mySprite");
        float verticalInput = go.transform.position.y;
        float myverticalInput = transform.position.y;
        float y1 = (verticalInput - myverticalInput) * -1;
        y = y1 / 18;
    }

    // Update is called once per frame
    void Update()
    {
        //get the Input from Horizontal axis        
        //get the Input from Vertical axis
        //update the position
        transform.position = transform.position + new Vector3(horizontalinputf * -1 * y * movement_speed * Time.deltaTime, 0, 0);
        if(transform.position.x < -19)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
