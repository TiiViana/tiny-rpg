using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowBehaviour : MonoBehaviour
{
    private float speed = 8f;
    private float speedNegative = -8f;
    public Rigidbody2D rb;
    private float timer;
   
    void Start()
    {
        GameObject player = GameObject.Find("Player");

        if(player.GetComponent<PlayerBow>().direction == 0)
        {
            rb.velocity = transform.right * speedNegative;
        }

        if (player.GetComponent<PlayerBow>().direction == 1)
        {
            rb.velocity = transform.right * speedNegative;
        }

        if (player.GetComponent<PlayerBow>().direction == 2)
        {
            rb.velocity = transform.right * speedNegative;
        }

        if (player.GetComponent<PlayerBow>().direction == 3)
        {
            rb.velocity = transform.right * -speed;
        }
    }

    
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 5){
            Destroy(gameObject);
        }
    }
}
