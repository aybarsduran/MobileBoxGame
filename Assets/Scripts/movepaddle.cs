using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movepaddle : MonoBehaviour
{

    Rigidbody2D rb;
    public float speed;
    public bool moveright=false;
    public bool moveleft = false;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        moveright = false;
     moveleft = false;


}

// Update is called once per frame
void Update()
    {
      
    }
    private void FixedUpdate()
    {
        TouchMove();
    }
    public void TouchMove()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(touchPosition.x < 0)
            {
                rb.velocity = Vector2.left * speed;
                moveleft = true; 
                
            }
            else
            {
                rb.velocity = Vector2.right * speed;
                moveright = true;

            }
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
