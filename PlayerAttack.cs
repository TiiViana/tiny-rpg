using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    //Refence
    public Animator animator;

    //Variables
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if(Input.GetMouseButtonDown(0))
		{
            swordAttack();
        }
        if (timer >= 0.30)
        {
            animator.SetBool("Attack", false);
            gameObject.GetComponent<PlayerMovement>().moveSpeed = 4f;
        }
    }

    void swordAttack()
    {
        timer = 0;
        animator.SetBool("Attack", true);
        gameObject.GetComponent<PlayerMovement>().moveSpeed = 0f;
    }
}
