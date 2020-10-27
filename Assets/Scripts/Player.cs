using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 3.5f;    
    [SerializeField]
    private GameObject _laser;

    
    //public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_laser, transform.position, Quaternion.identity);
        }       
    }

    void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
        transform.Translate(direction * speed * Time.deltaTime);


        //if player postion on the the  y is greater than 0 
        //y postion = 0
        //else if postion on the y is less than -3.8f
        //y pos = -3.8f
        if (transform.position.y >= 0)
        {
            transform.position = new Vector3(transform.position.x, 0, 0);
        }
        else if (transform.position.y <= -3.8f)
        {
            transform.position = new Vector3(transform.position.x, -3.8f, 0);
        }


        // if player on the x is greater than x > 11
        //x pos = 11 
        //else if player on the x is less than -11\
        //x pos = 11
        if (transform.position.x > 11)
        {
            //transform.position = new Vector3(11, transform.position.y, 0);
            transform.position = new Vector3(-11, transform.position.y, 0);
        }
        else if (transform.position.x < -11)
        {
            //transform.position = new Vector3(-11, transform.position.y, 0);
            transform.position = new Vector3(11, transform.position.y, 0);
        }
    }    
    //if condition 
    //then run code
    //else if () {}

}
