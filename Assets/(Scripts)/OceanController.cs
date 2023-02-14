using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanController : MonoBehaviour
{
    public float verticalSpeed;
    Boundary boundary;

    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    void FixedUpdate()
    {
        Move();
        CheckBounds();
    }

    void Move()
    {
        transform.position -= new Vector3(0.0f, verticalSpeed);
    }

    void CheckBounds()
    {
        if(transform.position.y <= boundary.bottom)
        {
            ResetObject();
        }
    }

    void ResetObject()
    {
        transform.position = new boundary.top;
    }
}
