using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataform : MonoBehaviour
{
    private Transform BackPoint;
    
    void Start()
    {
        BackPoint = GameObject.Find("BackPoint").GetComponent<Transform>();
    }


    void Update()
    {
        if(transform.position.x < BackPoint.position.x){
            Destroy(gameObject);
        }
    }
}
