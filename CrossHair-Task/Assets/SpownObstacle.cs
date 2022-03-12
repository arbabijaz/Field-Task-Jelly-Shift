using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpownObstacle : MonoBehaviour
{
    public GameObject[] obstacle;
    public PlayerController player;
    
    void Start()
    {
        InvokeRepeating("objectSpowning", 1, 4);

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void objectSpowning()
    {
        Vector3 position = new Vector3(-0.23f, 0, 50);
        int index = Random.Range(0, obstacle.Length);
        position.y += obstacle[index].transform.position.y;
        if (player.isAlive)
        {
            Instantiate(obstacle[index], position, obstacle[index].transform.rotation);
        }
        
        
    }
}
