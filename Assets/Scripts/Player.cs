using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]private float _playerSpeed = 5;
    private float _playerInput;
    private float _playerSpeed2 = 5;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       PlayerMovement();
    
    }
    
    void PlayerMovement()
       {
        _playerInput = Input.GetAxis("Horizontal");
        _playerSpeed2 = Input.GetAxis("Vertical");

       transform.Translate(new Vector2(_playerInput, _playerSpeed2) * _playerSpeed * Time.deltaTime);
       }
        
    
}
