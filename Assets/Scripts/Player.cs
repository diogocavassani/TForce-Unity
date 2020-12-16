using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    public GameObject bullet;
    public Transform FirePoint;
    public GameObject smoke;
    private bool isJump;
    private Rigidbody2D rig;

    void Start()
    {
       rig = GetComponent<Rigidbody2D>(); 
    }


    void FixedUpdate()
    {
        rig.velocity = new Vector2(Speed * Time.deltaTime, rig.velocity.y);
        
        if (Input.GetKey(KeyCode.Space) && !isJump)
        {
            rig.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            isJump = true;
            smoke.SetActive(true);
        }

        if (Input.GetKey(KeyCode.X))
        {
            Instantiate(bullet, FirePoint.transform.position, FirePoint.transform.rotation);
        }
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJump = false;
            smoke.SetActive(false);
        }
    }
}
