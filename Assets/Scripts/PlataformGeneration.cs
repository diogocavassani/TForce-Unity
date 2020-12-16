using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformGeneration : MonoBehaviour
{
    public GameObject Plataform;
    
    public Transform Point;
    public float maxDistance;
    public float minDistance;
    private float PlataformWidth;

    void Start()
    {
        if (Plataform.GetComponent<BoxCollider2D>())
        {
            PlataformWidth = Plataform.GetComponent<BoxCollider2D>().size.x;
        }
        else
        {
            PlataformWidth = Plataform.GetComponent<PolygonCollider2D>().bounds.size.x;
        }
        
    }

    void Update()
    {
        if(transform.position.x < Point.position.x)
        {
            float Distance = Random.Range(minDistance, maxDistance);
            transform.position = new Vector3
            (
                transform.position.x + PlataformWidth + Distance, 
                transform.position.y, 
                0
                );

            Instantiate(Plataform, transform.position, transform.rotation);
        }
    }
}
