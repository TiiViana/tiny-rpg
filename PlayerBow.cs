using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBow : MonoBehaviour
{
    //Refence
    public Animator animator;
    public Transform firePoint;
    public GameObject arrowPrefab;
    public int direction;

    //Variables
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetMouseButtonDown(1))
        {
            bowAttack();
        }
        if (timer >= 2)
        {
            animator.SetBool("Bow", false);
            gameObject.GetComponent<PlayerMovement>().moveSpeed = 4f;
        }

        //Firepoint position
        if (Input.GetKeyDown(KeyCode.W))
        {
            firePoint.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 0.7f);
            firePoint.rotation = Quaternion.Euler(0, 0, 270f);
            direction = 0;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            firePoint.position = new Vector2(gameObject.transform.position.x + 0.7f, gameObject.transform.position.y);
            firePoint.rotation = Quaternion.Euler(0, 0, 180f);
            direction = 1;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            firePoint.position = new Vector2(gameObject.transform.position.x + -0.7f, gameObject.transform.position.y);
            firePoint.rotation = Quaternion.Euler(0, 0, 0f);
            direction = 2;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            firePoint.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + -0.7f);
            firePoint.rotation = Quaternion.Euler(0, 0, 90f);
            direction = 3;
        }
    }

    void bowAttack()
    {
        gameObject.GetComponent<PlayerMovement>().moveSpeed = 0f;
        timer = 0;
        animator.SetBool("Bow", true);
        Instantiate(arrowPrefab, firePoint.position, firePoint.rotation);
    }

}
