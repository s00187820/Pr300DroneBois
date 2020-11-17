using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinMap : MonoBehaviour
{
    public Transform playr;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    void LateUpdate()
    {
        Vector3 newPos = playr.position;
        newPos.y = transform.position.y;
        transform.position = newPos;
    }
}
