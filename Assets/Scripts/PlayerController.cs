using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public const string HORIZONTAL = "Horizontal", VERTICAL = "Vertical";
    private float inputTol = 0.2f; // Input tolerance
    private float xInput, yInput;

    private bool isWalking;
    private Vector2 lastDirection;
    private Animator _animator;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        xInput = Input.GetAxisRaw(HORIZONTAL);
        yInput = Input.GetAxisRaw(VERTICAL);
        isWalking = false;

        if (Mathf.Abs(xInput) > inputTol)
        {
            _rigidbody.velocity = new Vector2(xInput * speed, _rigidbody.velocity.y);
            isWalking = true;
            lastDirection = new Vector2(xInput, y: 0);
        }

       
        if (Mathf.Abs(yInput) > inputTol)
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, yInput * speed);
            isWalking = true;
            lastDirection = new Vector2(0, yInput);
        }
    }

    private void LateUpdate()
    {
        if (!isWalking)
        {
            _rigidbody.velocity = new Vector2(0, 0); //_rigidbody.velocity = Vector2.zero
        }
        _animator.SetFloat(HORIZONTAL, xInput);
        _animator.SetFloat(VERTICAL, yInput);
        _animator.SetFloat("LastHorizontal", lastDirection.x);
        _animator.SetFloat("LastVertical", lastDirection.y);
        _animator.SetBool("IsWalking", isWalking);
    }

}