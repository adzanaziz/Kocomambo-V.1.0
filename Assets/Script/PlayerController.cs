using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpSpeed = 10f;
    [SerializeField] private Rigidbody2D rb;

   private void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector2 jumpDirection = new Vector2(0, 1);
            rb.velocity = jumpDirection * jumpSpeed;
        }
                

    }



    
  private  void Move()
    {
        //Debug.Log(Input.GetAxis("Horizontal"));
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 direction = new Vector2(horizontal, 0);
       transform.Translate(direction * moveSpeed * Time.deltaTime);
    }
}
