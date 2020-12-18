using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Speed;
    public float minSpeed;
    public float maxSpeed;   
    private Transform backPoint;
    private Animator animator;
    private Rigidbody2D rig;
    void Start() 
    {
        backPoint = GameObject.Find("BackPoint").GetComponent<Transform>();
        animator = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
 
    }



    void Update()
    {
        Speed = Random.Range(minSpeed,maxSpeed);
       //transform.Translate(Vector3.left * Speed * Time.deltaTime); 
       rig.velocity = new Vector2(-Speed, rig.velocity.y);

       if (transform.position.x <= backPoint.position.x)
       {
           Destroy(gameObject);
       }
    }
    void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.tag == "Bullet")
        {
            GetComponent<CircleCollider2D>().enabled = false;
            GameController.current.AddScore(10);
            animator.SetTrigger("destroy");
            Destroy(gameObject, 1f);
        }
    }
}
