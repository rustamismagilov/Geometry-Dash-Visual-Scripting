using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool ground = true;
    public float gravity = -25;
    public float speed = 5;
    public float jump = 10;
    Rigidbody2D rgb;
    int isBreak=0;
    void Start()
    {
        Physics2D.gravity = new Vector2(0, gravity);
        rgb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        ground = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
         ground = false;
    }
    void Update()
    {
        
        rgb.velocity = new Vector2(speed, rgb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && ground && isBreak<5)
        {
            isBreak++;
            rgb.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }

    }
   
}
