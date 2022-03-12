using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class obstacleController : MonoBehaviour
{
    public float speed = 20;
    Vector3 pos= new Vector3(0, 3.84f, 0);
    private bool loose = false;
    int damage = 100;
    
    Rigidbody obstacle;
    // Start is called before the first frame update
    void Start()
    {
        obstacle = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        obstacle.velocity = new Vector3(0, 0, -speed);
        if (transform.position.z < -8)      //Destroy obstacle that goes out of boundary 
        {
            Destroy(gameObject);    
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerController>().getDamage(damage);
            Debug.Log("Player Collided ");
            
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerController>().addScore();       //add score 
           
        }
    }
}
