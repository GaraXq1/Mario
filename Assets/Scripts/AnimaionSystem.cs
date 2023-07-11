using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaionSystem : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private SpriteRenderer sr;
    private string died = "Died";
    private string isJump = "IsJump";
    private string speed = "Speed";

    
    public void SetPlayerAnimaion(float moveVector, float jumping)
    {
        animator.SetFloat(speed, Mathf.Abs(moveVector));
        if(moveVector > 0)
        {
            sr.flipX = false;
        }
        if(moveVector < 0)
        {
            sr.flipX = true;
        }

        bool isJumping = false;
        if(jumping == 0)
        {
            isJumping = false;
        }
        if(jumping != 0)
        {
            isJumping = true;
        }
        animator.SetBool(isJump, isJumping);
    }



}
