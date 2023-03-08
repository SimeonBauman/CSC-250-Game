using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Movement : MonoBehaviour
{
    
    private Rigidbody rb;
    public int speed = 10;
    private PlayerInput inputS;
    Vector2 moveData;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        inputS = GetComponent<PlayerInput>();   
    }

    void OnMove(InputValue v)
    {
        moveData = v.Get<Vector2>() * 10; 
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(new Vector3(moveData.x,0,moveData.y));
        //rb.velocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * speed;
      
    }

    
}
