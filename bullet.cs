using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

     void Update()
    {
        if(transform.position.x>6.5f)
        {
            Destroy(gameObject);
        }
    }
}
