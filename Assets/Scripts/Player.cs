using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Player Stats")]
    [Tooltip("Controla la velocidad de movimiento de nuestro personaje")]
    [SerializeField]private float _playerSpeed = 5;
    [Tooltip("Controla la fuerza de salto del personaje")]
    
    [SerializeField]private float _jumpForce = 5;

    private float _playerInput;
    //private float _playerSpeed2 = 5;

    private Rigidbody2D _rBody2D;
    private GroundSensor _sensor;
    private Animator _animator;


    // Start is called before the first frame update
    void Start()
    {

      _rBody2D = GetComponent<Rigidbody2D>();
      _sensor = GetComponentInChildren<GroundSensor>();
      _animator = GetComponentInChildren<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
       PlayerMovement();

       if(Input.GetButtonDown("Jump") && _sensor._isGrounded)
       {
         Jump();
       }
    
    }

    void FixedUpdate()
    {
      //_rBody2D.AddForce(new Vector2(_playerInput * _playerSpeed, 0),ForceMode2D.Impulse);

      _rBody2D.velocity = new Vector2(_playerInput * _playerSpeed, _rBody2D.velocity.y);
    }
    
    void PlayerMovement()
       {
       _playerInput = Input.GetAxis("Horizontal");

       if(_playerInput != 0)
        {
          _animator.SetBool("IsRunning", true);
        }
       
       if(_playerInput == 0)
        {
          _animator.SetBool("IsRunning", false);
        }
        /*_playerSpeed2 = Input.GetAxis("Vertical");

       transform.Translate(new Vector2(_playerInput, _playerSpeed2) * _playerSpeed * Time.deltaTime);*/
       }
        
        void Jump()
        {
         _rBody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);

         _animator.SetBool("IsJumpin", true);
        }
        
    
}
