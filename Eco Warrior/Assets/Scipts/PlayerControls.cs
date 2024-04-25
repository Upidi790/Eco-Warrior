using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    private PlayerControls playerControls;
    private Vector2 movement;
    private Rigidbody2D rb;
    private Animator myAnimator;
    private SpriteRenderer mySpriteRenderer;
    private Transform myTransform;
    private SpriteRenderer swordRenderer;
    private Transform swordTransform;
    private void Awake() {
        playerControls = new PlayerControls();
        rb = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        myTransform = GetComponent<Transform>();
        GameObject sword = GameObject.Find("Sword");
        swordRenderer = sword.GetComponent<SpriteRenderer>();
        swordTransform = sword.GetComponent<Transform>();
    }
    private void OnEnable() {
        playerControls.Enable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        PlayerInput();
    }
    private void FixedUpdate() {
        AdjustPlayerFacingDirection();
        Move();
    }
    private void PlayerInput()
    {
        movement = playerControls.Movement.Move.ReadValue<Vector2>();
        myAnimator.SetFloat("moveX", movement.x);
        myAnimator.SetFloat("moveY", movement.y);
    }
    private void Move()
    {
        rb.MovePosition(rb.position + movement * (moveSpeed * Time.fixedDeltaTime));
    }
    private void AdjustPlayerFacingDirection()
    {
        if (movement.x != 0)
        {
            if (movement.x < 0)
            {
                mySpriteRenderer.flipX = true;
                swordRenderer.flipX = true;
                swordTransform.position = new Vector3(myTransform.position.x-0.87f, swordTransform.position.y, swordTransform.position.z);
            }
            else
            {
                mySpriteRenderer.flipX = false;
                swordRenderer.flipX = false;
                swordTransform.position = new Vector3(myTransform.position.x+0.82f, swordTransform.position.y, swordTransform.position.z);
            }
        }
    }
}
