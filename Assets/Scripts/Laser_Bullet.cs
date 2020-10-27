using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_Bullet : MonoBehaviour
{    
    private float _speed = 10f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        // translate laser up       
        transform.Translate(Vector3.up * _speed * Time.deltaTime);
        

        //if laser position on the greater than 8 on the y
        //detroy the object

        if (transform.position.y > 8f)
        {
            Destroy(this.gameObject, 5f);
        }
    }
}
