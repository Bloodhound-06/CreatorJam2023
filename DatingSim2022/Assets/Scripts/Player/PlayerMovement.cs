using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [Header("Float")]
    public float speed = 5f;
    public float Jumpforce = 5f;
    public float maxDistance;

    [Header("Vector")]
    private Vector3 movement;
    public Vector3 boxSize;

    [Header("References")]
    public Rigidbody2D rb;

    [Header("Keybinds")]
    public KeyCode jumpKey;

    [Header("LayerMask")]
    public LayerMask layerMask;


    private void Update()
    {
        AnimationChange();
        Jump();
    }
    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        transform.position = transform.position + speed * Time.deltaTime * movement;
    }

    private void Jump()
    {
        if (Input.GetKeyDown(jumpKey) && GroundCheck())
        {
            rb.AddForce(new Vector2(0, Jumpforce), ForceMode2D.Impulse);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(transform.position - transform.up * maxDistance, boxSize);
    }
    private bool GroundCheck()
    {
        if (Physics2D.BoxCast(transform.position, boxSize, 0, -transform.up, maxDistance, layerMask))
        {
            return true;
        }
        else return false;
    }


    private void AnimationChange()
    {
        if (movement.x <= 0)
        {
            //move right
        }
        else if (movement.x >= 0)
        {
            //move left
        }
        else
        {
            //idle animation
        }

    }
}
