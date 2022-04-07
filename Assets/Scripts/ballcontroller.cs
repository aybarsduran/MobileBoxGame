using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ballcontroller : MonoBehaviour
{
    Rigidbody2D rb;
    bool gameStarted = false;
    public float bounceForce;
    public movepaddle paddle;

    private void Awake()
    {

        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        gameStarted = false;
      
        paddle=GetComponent<movepaddle>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown && gameStarted==false)
        {
            StartBounce();
        }
        HareketEderkenYönVer();
        

    }
    void HareketEderkenYönVer()
    {
        if (paddle.moveleft == true) {
            Vector2 soladogru = new Vector2(-1, Random.Range(-1, 1));
            rb.AddForce(soladogru,ForceMode2D.Impulse); 
        }
        if (paddle.moveright == true) {
            Vector2 sagadogru = new Vector2(1, Random.Range(-1, 1));
            rb.AddForce(sagadogru,ForceMode2D.Impulse);
        }
    }
    void StartBounce()
    {
        Vector2 randomDirection = new Vector2(Random.Range(-1, 1), 1);
        rb.AddForce(randomDirection*bounceForce,ForceMode2D.Impulse);
        gameStarted = true;
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "fallCheck")
        {
            GameManager.instance.Restart();
        }
        if(collision.gameObject.tag == "boxes")
        {
            Object.Destroy(collision.gameObject); 
        }
    }
}
