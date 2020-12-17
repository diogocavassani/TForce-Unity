using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed;

    void Start() 
    {
        Destroy(gameObject, 0.5f);
    }
    void Update()
    {
        transform.Translate(Vector3.right * Speed * Time.deltaTime);

        
    }
}
