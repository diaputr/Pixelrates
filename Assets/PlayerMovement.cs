using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    
    private Rigidbody2D _rbody;
    float _horizontalMovement;

    public float HorizontalMovement{
        private set
        {
            if (value != _horizontalMovement)
            {
                _horizontalMovement = value;
            }
        } 
        get => _horizontalMovement;
    }

    private void Awake()
    {
        _rbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMovement = Input.GetAxis("Horizontal");

    }

    private void FixedUpdate()
    {
        Move();        
    }

    private void Move()
    {
        _rbody.velocity = new Vector2(
            moveSpeed * HorizontalMovement, 
            _rbody.velocity.y
        );
        
    }
}
