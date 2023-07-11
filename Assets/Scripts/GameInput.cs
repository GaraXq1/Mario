using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    private float jumpAmount = 35;
    private float gravityScale = 10;
    private float fallingGravityScale = 30;
    private float inputVector = 0;
    

    public float GetMovementVectorNormalized()
    {
        inputVector = 0;
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            inputVector = 1f;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            inputVector = -1f;
        }
        return inputVector;
    }
    public void Jump(Rigidbody2D rb)
    {
        if (Input.GetKeyDown(KeyCode.Space) && rb.velocity.y == 0)
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            
        }
        if (rb.velocity.y >= 0)
        {
            rb.gravityScale = gravityScale;
        }
        else if (rb.velocity.y < 0)
        {
            rb.gravityScale = fallingGravityScale;
        }
    }
}
