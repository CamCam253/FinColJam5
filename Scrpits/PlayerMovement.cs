using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D player;
    private Vector2 movementDirection;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    private void FixedUpdate()
    {
        player.velocity = movementDirection * PlayerManager.moveSpeed;
        if (player.velocity != Vector2.zero)
        {
            animator.SetFloat("PlayerSpeed", movementSpeed);
        }
        else
        {
            animator.SetFloat("PlayerSpeed", 0);
        }
    }
}
