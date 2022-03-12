using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Vector3 horizontalScale = new Vector3(7, 0.5f, 1);
    private Vector3 verticalScale = new Vector3(0.7f, 3.2f, 1);
    public TextMeshProUGUI scoreTxt;
    public float speed=5;
    public int score=0;
    public int health=100;
    public bool isAlive = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            Debug.Log("C pressed");
            
            
            transform.localScale = Vector3.Lerp(transform.localScale, horizontalScale, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.V))
        {
            Debug.Log("V pressed");
            transform.localScale = Vector3.Lerp(transform.localScale, verticalScale, speed * Time.deltaTime);


            
        }
        scoreTxt.SetText("Score : " + score);
        healthChecker();
    }
    public void addScore()
    {
        score++;
        Debug.Log(score);
    }
    public void getDamage(int damage)
    {
        if (healthChecker())
        {
            health -= damage;
        }
        
    }
    public bool healthChecker()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Player Died");
            isAlive = false;
            return false;
        }
        return true;
    }
    
}
