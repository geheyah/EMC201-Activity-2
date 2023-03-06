using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    [SerializeField]
    private float SprintM = 1.25f;
    
    [SerializeField]
    private bool Sprint = false;
    public float Speed = 10.0f;


    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        Vector2 movementInput = new Vector2(horizontal, vertical);

        Sprint = Input.GetKey(KeyCode.LeftShift);
        Move(movementInput);
    }

    void Move(Vector2 input)
    {
        float IfSprinting = 1.0f;    
        if (Sprint)
        {
            IfSprinting = SprintM;
        }

        Vector3 position = new Vector3(Speed * input.x, Speed * input.y, transform.position.z);
        transform.position = transform.position + (position * (Time.deltaTime * IfSprinting)); 
    }
}
