using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    public bool _isGrounded;
    
     void OntriggerEnter2D(Collider2D other)
     {
        if(other.gameObject.layer == 6)
        _isGrounded = true;

     }

     void OntriggerExit2D(Collider2D other)
     {
        if(other.gameObject.layer == 6)
        _isGrounded = false;

     }

     void OntriggerStay2D(Collider2D other)
     {
        if(other.gameObject.layer == 6)
        _isGrounded = true;

     }
}
