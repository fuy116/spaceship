using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_generator : MonoBehaviour
{
    public GameObject Bullet;


    public void shoot()
    {
            if(Input.GetKeyDown("g"))
            {
            Instantiate(Bullet,transform.position,transform.rotation);
            }
    }

 

}
