using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    
    private GameInput gameInput;
    private AnimaionSystem animation;
    private float speed = 10f;

    private void Awake()
    {
        gameInput = GetComponent<GameInput>();
        animation = GetComponent<AnimaionSystem>();
    }

    private void Update()
    {
        
        gameInput.Jump(rb);

        float inputVector = gameInput.GetMovementVectorNormalized();
        Vector3 moveDir = new Vector3(inputVector, 0, 0);
        transform.position += moveDir * speed * Time.deltaTime;

        animation.SetPlayerAnimaion(gameInput.GetMovementVectorNormalized(), rb.velocity.y);
    }

}
